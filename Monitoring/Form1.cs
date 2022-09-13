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
using Renci.SshNet.Common;
using System.Diagnostics;
using Monitoring.Properties;

namespace Monitoring {
    public partial class Form1 : Form {
        SshClient ssh;
        bool isConnected = false;

        public Form1() {
            InitializeComponent();
            AddresLine.Text = Settings.Default["SaveHost"].ToString();
            UsernameLine.Text = Settings.Default["SaveUsername"].ToString();
            PortLine.Text = Settings.Default["SavePort"].ToString();
        }

        async void autoTemperatureUpdate() {
            while (true) {
                richTextBox1.Text = await Task.Run(() => {
                    try {
                        var conclusion = ssh.RunCommand("sensors coretemp-isa-0000");
                        string[] lines = conclusion.Result.Split(new string[] { "\n" }, StringSplitOptions.None);
                        string coresStr = string.Join("\n", lines.Where(s => s.StartsWith("Core")).Select(s => s.Remove(s.IndexOf('('))));
                        return coresStr;
                    } catch { return ""; }

                });
                await Task.Run(() => Thread.Sleep(2000));
            }
        }

        private void onConnectClick(object sender, EventArgs e) {
            try
            {
                if (isConnected)
                    ssh.Disconnect();
                //
                string adres = AddresLine.Text;
                int port = int.Parse(PortLine.Text);
                string userName = UsernameLine.Text;
                string password = PasswordLine.Text;
                Settings.Default["SaveHost"] = AddresLine.Text;
                Settings.Default["SaveUsername"] = UsernameLine.Text;
                Settings.Default["SavePort"] = PortLine.Text;
                Settings.Default.Save();
                ssh = new SshClient(adres, port, userName, password);
                ssh.Connect();
                //
                var DaemonNames = ssh.RunCommand("ls /etc/systemd/system | grep .service").Result;
                String[] words = DaemonNames.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                name_list.Items.AddRange(words);
                //
                var procentUsed = ssh.RunCommand("df -h / --output=pcent").Result;
                string deleteBlyat = procentUsed.Substring(4);
                string[] lines = deleteBlyat.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                string DiskUsed = string.Join("\n",
                    lines.Where(s => s.EndsWith("%")).Select(s => s.Remove(s.IndexOf('%'))));
                DiskInfo.Value = int.Parse(DiskUsed);
                //
                GUIonConnect();
                autoTemperatureUpdate();
                //
            }
            catch (Renci.SshNet.Common.SshAuthenticationException)
            {
                var hhhh = MessageBox.Show("Incorrect data"
                    , "Problems with access to JoyCasino",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (System.Net.Sockets.SocketException)
            {
                var ErrorConnection = MessageBox.Show("Incorrect addres"
                    , "Problems with access to JoyCasino",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (System.ArgumentException)
            {
                var ErrorConnection = MessageBox.Show("Check if the fields are filled"
                    , "The field is empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void GUIonConnect() {
            NewConn.Enabled = true;
            MainGroup.Enabled = true;
            ConnGroup.Enabled = false;
            Connection.Enabled = false;
        }

        private void onStatusBtnClick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctlStatus = ssh.RunCommand("systemctl status " + Service_Name).Result;
            systemctlOut.Text = systemctlStatus;
        }

        private void onStartBtnCLick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctlStart = ssh.RunCommand("sudo systemctl start " + Service_Name);
        }

        private void onStopBtnClick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctlStop = ssh.RunCommand($"sudo systemctl stop {Service_Name}");
        }

        private void onRestartBtnClick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctlRestart = ssh.RunCommand($"sudo systemctl restart {Service_Name}");
        }

        private void RebootBtn(object sender, EventArgs e) {
            try {
                NewConn_Click(NewConn, null);
                var Reboot = ssh.RunCommand("sudo reboot now");
            } catch (Renci.SshNet.Common.SshConnectionException) {
                var ErrorConnection = MessageBox.Show("Server reboot",
                    "Client is disconnected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            
        }

        private void ShutdownBtn(object sender, EventArgs e) {
            try {
                NewConn_Click(NewConn, null);
                var shutdown = ssh.RunCommand("sudo shutdown now");
            } catch (Renci.SshNet.Common.SshConnectionException) {
                var ErrorConnection = MessageBox.Show("Server reboot",
                    "Client is disconnected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        
        private void NewConn_Click(object sender, EventArgs e) {
            ssh.Disconnect();
            ConnGroup.Enabled = true;
            name_list.SelectedIndex = -1;
            ftpLog.Text = "Login";
            ftpPass.Text = "Password";
            name_list.Items.Clear();
            systemctlOut.Clear();
            AddresLine.Clear();
            UsernameLine.Clear();
            PasswordLine.Clear();
            DiskInfo.Value = int.Parse("0");
            MainGroup.Enabled = false;
        }

        private void ftpOpen(object sender, EventArgs e) {
            Process.Start("explorer.exe", $"ftp://{ftpLog.Text}:{ftpPass.Text}@{AddresLine.Text}");
        }

        private void UpdateCollection_Click(object sender, EventArgs e) {
            name_list.Items.Clear();
            var names = ssh.RunCommand("ls /etc/systemd/system | grep .service").Result;
            String[] words = names.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            name_list.Items.AddRange(words);
        }

        private void onButtonInstallClick(object sender, EventArgs e) {
            var Install = ssh.RunCommand($"sudo apt install -y {packageNameText.Text}");
        }

        private void onRemoveButtonClick(object sender, EventArgs e) {
            var Remove = ssh.RunCommand($"sudo apt remove -y {packageNameText.Text}");
        }

        private void OpenForm3_Click(object sender, EventArgs e) {
            SSH_Data_Transf.Adres = AddresLine.Text;
            SSH_Data_Transf.Port = PortLine.Text;
            SSH_Data_Transf.Username = UsernameLine.Text;
            SSH_Data_Transf.Password = PasswordLine.Text;
            Form f2 = new Form3();
            f2.Show();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyValue == (char)Keys.Enter) {
                onConnectClick(Connection, null);
            }
        }
        private void AddresLine_TextChanged(object sender, EventArgs e) {

        }
        private void DiskUsedProgressBar(object sender, EventArgs e) {
        }
    }
}