using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace Monitoring {
    public partial class Form3 : Form 
    {
        SshClient ssh;
        public Form3() {
            InitializeComponent();
            connection();
        }
        public void connection() {
            string host = SSH_Data_Transf.Adres;
            int port = int.Parse(SSH_Data_Transf.Port);
            string username = SSH_Data_Transf.Username;
            string password = SSH_Data_Transf.Password;
            ssh = new SshClient(host,port, username, password);
            ssh.Connect();
            //
            var conclusion = ssh.RunCommand("sudo fail2ban-client status | grep Jail");
            string deleteBlyat = conclusion.Result.Substring(14);
            string[] JailList = deleteBlyat.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            JailDropList.Items.AddRange(JailList);
            JailDropList.SelectedIndex = 0;
            //
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

        public void UpdateIPlist() {
            BannedIPlist.Items.Clear();
            string jail = JailDropList.Text;
            var bannedIP = ssh.RunCommand($"sudo fail2ban-client status {jail} | grep Banned").Result;
            string deleteBlyat = bannedIP.Substring(22);
            string[] IPList = deleteBlyat.Split(new string[] { " " }, StringSplitOptions.None);
            BannedIPlist.Items.AddRange(IPList);
        }

        private void button1_Click(object sender, EventArgs e) {
            string IP = BannedIPlist.Text;
            string jail = JailDropList.Text;
            var unban_Command = ssh.RunCommand($"sudo fail2ban-client set {jail} unbanip {IP}");
            BannedIPlist.SelectedIndex = -1;
            UpdateIPlist();
        }

        private void BannedIPlist_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void Form3_Load(object sender, EventArgs e) {

        }
    }
}
