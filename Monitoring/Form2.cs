using Renci.SshNet;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring {


    public partial class Fail2ban : Form {
        SshClient ssh;

        public Fail2ban() {
            InitializeComponent();
            connection();
        }
        public void connection() {
            string host = SSH_data.Adres;
            string username = SSH_data.Username;
            string password = SSH_data.Password;
            ssh = new SshClient(host, username, password);
            ssh.Connect();
            var conclusion = ssh.RunCommand("sudo fail2ban-client status | grep Jail");
            string deleteBlyat = conclusion.Result.Substring(14);
            string[] JailList = deleteBlyat.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            JailDropList.Items.AddRange(JailList);
            JailDropList.SelectedIndex = 0;
            autoBanUpdate();
            UpdateIPlist();
        }

        async void autoBanUpdate() {
            while (true) {
                string jail = JailDropList.Text;
                TableFailBox.Text = await Task.Run(() => {
                    try { 
                        var status = ssh.RunCommand($"sudo fail2ban-client status {jail}").Result;
                        return status;
                    } catch { return ""; }
                });
                await Task.Run(() => Thread.Sleep(1000));
            }
        }
        private void Unban_btn_Click(object sender, EventArgs e) {
            string IP = BannedIPlist.Text;
            string jail = JailDropList.Text;
            var unban_Command = ssh.RunCommand($"sudo fail2ban-client set {jail} unbanip {IP}");
            BannedIPlist.SelectedIndex = -1;
            UpdateIPlist();
        }

        public void UpdateIPlist() {
            BannedIPlist.Items.Clear();
            string jail = JailDropList.Text;
            var bannedIP = ssh.RunCommand($"sudo fail2ban-client status {jail} | grep Banned").Result;
            string deleteBlyat = bannedIP.Substring(22);
            string[] IPList = deleteBlyat.Split(new string[] { " " }, StringSplitOptions.None);
            BannedIPlist.Items.AddRange(IPList);
        }
    }
}
