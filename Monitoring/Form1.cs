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

namespace Monitoring {
    public partial class Form1 : Form {
        SshClient ssh;
        bool isConnewcted = false;

        public Form1() {
            InitializeComponent();
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
            try {
                if (isConnewcted)
                    ssh.Disconnect();
                string adres = AddresLine.Text;
                int port = 22;
                if (AddresLine.Text.Contains(':')) {
                    adres = adres.Substring(0, AddresLine.Text.IndexOf(':'));
                    port = int.Parse(AddresLine.Text.Substring(AddresLine.Text.IndexOf(':') + 1));
                }
                string userName = UsernameLine.Text;
                string password = PasswordLine.Text;

                ssh = new SshClient(adres, port, userName, password);
                ssh.Connect();
                var names = ssh.RunCommand("ls /etc/systemd/system | grep .service").Result;
                String[] words = names.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                name_list.Items.AddRange(words);
                var resultData = ssh.RunCommand("df -H /dev/sda1 --output=used").Result;
                string[] lines = resultData.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                string DiskUsed = string.Join("\n", lines.Where(s => s.EndsWith("G")).Select(s => s.Remove(s.IndexOf('G'))));
                var procentsData = ssh.RunCommand("df -H /dev/sda1").Result;
                //string[] OhNo = procentsData.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                //string DiskProcents = string.Join("\n", OhNo.Where(s => s.EndsWith("%")).Select(s => s.Remove(s.IndexOf('%'))));
                packageInstallgroup.Enabled = true;
                NewConn.Enabled = true;
                ControlGroup.Enabled = true;
                SystemctlGroup.Enabled = true;
                isConnewcted = true;
                TempBox.Enabled = true;
                AddresLine.Enabled = false;
                UsernameLine.Enabled = false;
                PasswordLine.Enabled = false;
                Connection.Enabled = false;
                DiskInfo_group.Enabled = true;
                DiskInfo.Value = Convert.ToInt32(DiskUsed);
                diskInfoLabel.Text = $"used: {DiskUsed}G";
                ftpGroup.Enabled = true;
                autoTemperatureUpdate();
            } catch (Renci.SshNet.Common.SshAuthenticationException) {
                var hhhh = MessageBox.Show("Incorrect data"
                    , "Problems with access to JoyCasino",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }catch (System.Net.Sockets.SocketException) {
                var ErrorConnection = MessageBox.Show("Incorrect addres"
                    , "Problems with access to JoyCasino",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddresLine_TextChanged(object sender, EventArgs e) {

        }

        private void onStatusBtnClick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctl = ssh.RunCommand("systemctl status " + Service_Name).Result;
            systemctlOut.Text = systemctl;
        }

        private void onStartBtnCLick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctl = ssh.RunCommand("sudo systemctl start " + Service_Name);
        }

        private void onStopBtnClick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctl = ssh.RunCommand($"sudo systemctl stop {Service_Name}");
        }

        private void onRestartBtnClick(object sender, EventArgs e) {
            string Service_Name = name_list.Text;
            var systemctl = ssh.RunCommand($"sudo systemctl restart {Service_Name}");
        }

        private void DiskUsedProgressBar(object sender, EventArgs e) {
            DiskInfo.Value = 27;
        }

        private void RebootBtn(object sender, EventArgs e) {
            ControlGroup.Enabled = false;
            SystemctlGroup.Enabled = false;
            isConnewcted = false;
            TempBox.Enabled = false;
            var systemctl = ssh.RunCommand("sudo reboot now");
            ssh.Disconnect();
        }

        private void ShutdownBtn(object sender, EventArgs e) {
            ControlGroup.Enabled = false;
            SystemctlGroup.Enabled = false;
            isConnewcted = false;
            TempBox.Enabled = false;
            var systemctl = ssh.RunCommand("sudo shutdown now");
            ssh.Disconnect();
        }

        private void NewConn_Click(object sender, EventArgs e) {
            ftpLog.Clear();
            ftpPass.Clear();
            name_list.Items.Clear();
            systemctlOut.Clear();
            packageInstallgroup.Enabled = false;
            ftpGroup.Enabled = false;
            DiskInfo.Value = 0;
            ControlGroup.Enabled = false;
            SystemctlGroup.Enabled = false;
            isConnewcted = false;
            TempBox.Enabled = false;
            DiskInfo_group.Enabled = false;
            ssh.Disconnect();
            AddresLine.Clear();
            UsernameLine.Clear();
            PasswordLine.Clear();
            UsernameLine.Enabled = true;
            AddresLine.Enabled = true;
            PasswordLine.Enabled = true;
            Connection.Enabled = true;
        }

        private void ftpOpen(object sender, EventArgs e) {
            Process.Start("explorer.exe", $"ftp://{ftpLog.Text}:{ftpPass.Text}@{AddresLine.Text}");
        }

        private void UpdateCollection_Click(object sender, EventArgs e) {
            diskInfoLabel.Text = "used:";
            name_list.Items.Clear();
            var names = ssh.RunCommand("ls /etc/systemd/system | grep .service").Result;
            String[] words = names.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            name_list.Items.AddRange(words);
        }

        private void onButtonInstallClick(object sender, EventArgs e) {
            var systemctl = ssh.RunCommand($"sudo apt install -y {packageNameText.Text}");
        }

        private void onRemoveButtonClick(object sender, EventArgs e) {
            var systemctl = ssh.RunCommand($"sudo apt remove -y {packageNameText.Text}");
        }
    }
}