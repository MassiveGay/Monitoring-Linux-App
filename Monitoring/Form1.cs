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
                await Task.Run(() => Thread.Sleep(500));
            }
        }
        //Получаю процент использования процессора дефолтными функциями
        async void CpuUsed() {
            while (true) {
                textBox1.Text = await Task.Run(() => {
                    try {
                        var conclusion = ssh.RunCommand("awk '{u=$2+$4; t=$2+$4+$5; if (NR==1){u1=u; t1=t;} else print ($2+$4-u1) * 100 / (t-t1); }' <(grep 'cpu ' /proc/stat) <(sleep 1;grep 'cpu ' /proc/stat)");
                        return conclusion.Result;
                    } catch { return ""; }

                });
                await Task.Run(() => Thread.Sleep(500));
            }
        }
        //Получаю оперативку дефолтными функциями в килобайтах
        async void RAM() {
            while (true) {
                progressBar1.Value = int.Parse(await Task.Run(() => {
                    try {
                        var memTotal = ssh.RunCommand("vmstat -s | grep -i 'total memory' | sed 's/ *//'").Result;
                        string[] total = memTotal.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        string mem = string.Join("\n",
                            total.Where(s => s.EndsWith("y")).Select(s => s.Remove(s.IndexOf('K'))));
                        progressBar1.Maximum = int.Parse(mem);
                        var memUsed = ssh.RunCommand("vmstat -s | grep -i 'used memory' | sed 's/ *//'").Result;
                        string[] Used = memUsed.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        string memU = string.Join("\n",
                            Used.Where(s => s.EndsWith("y")).Select(s => s.Remove(s.IndexOf('K'))));
                        int convertTotal = int.Parse(mem) / 1000000;
                        int convertUsed = int.Parse(memU) / 1000000;
                        RAM_label.Text = $"{convertUsed}Gb/{convertTotal}Gb";
                        return memU;
                    } catch { return ""; }

                }));
                await Task.Run(() => Thread.Sleep(500));
            }
        }
        //Обновляю прогрессбар с местом на системном диске
        async void SystemDisk() {
            while (true) {
                DiskInfo.Value = int.Parse(await Task.Run(() => {
                    try {
                        var procentUsed = ssh.RunCommand("df -h / --output=pcent").Result;
                        string deleteBlyat = procentUsed.Substring(4);
                        string[] lines = deleteBlyat.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        string DiskUsed = string.Join("\n",
                            lines.Where(s => s.EndsWith("%")).Select(s => s.Remove(s.IndexOf('%'))));
                        Disk_label.Text = DiskUsed + "%";
                        return DiskUsed;
                    } catch { return ""; }

                }));
                await Task.Run(() => Thread.Sleep(500));
            }
        }
        async void DaemonStatusOutput() {
                    while (true) {
                        systemctlOut.Text = await Task.Run(() => {
                            try {
                                var systemctlStatus = ssh.RunCommand("systemctl status " + name_list.Text).Result;
                                return systemctlStatus;
                            } catch { return ""; }
        
                        });
                        await Task.Run(() => Thread.Sleep(500));
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
                //Сохранение данных подключения
                Settings.Default["SaveHost"] = AddresLine.Text;
                Settings.Default["SaveUsername"] = UsernameLine.Text;
                Settings.Default["SavePort"] = PortLine.Text;
                Settings.Default.Save();
                //
                ssh = new SshClient(adres, port, userName, password);
                ssh.Connect();
                //
                var DaemonNames = ssh.RunCommand("ls /etc/systemd/system | grep .service").Result;
                String[] words = DaemonNames.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                name_list.Items.AddRange(words);
                //
                GUIonConnect();
                CpuUsed();
                autoTemperatureUpdate();
                RAM();
                SystemDisk();
                DaemonStatusOutput();
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
            Connection.Enabled = true;
            ConnGroup.Enabled = true;
            name_list.SelectedIndex = -1;
            name_list.Items.Clear();
            systemctlOut.Clear();
            AddresLine.Clear();
            UsernameLine.Clear();
            PasswordLine.Clear();
            DiskInfo.Value = int.Parse("0");
            MainGroup.Enabled = false;
        }

        private void UpdateCollection_Click(object sender, EventArgs e) {
            name_list.Items.Clear();
            var names = ssh.RunCommand("ls /etc/systemd/system | grep .service").Result;
            String[] words = names.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            name_list.Items.AddRange(words);
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

        private void progressBar1_Click(object sender, EventArgs e) {
        }

        private void button6_Click(object sender, EventArgs e) {
            SSH_Data_Transf.Adres = AddresLine.Text;
            SSH_Data_Transf.Port = PortLine.Text;
            SSH_Data_Transf.Username = UsernameLine.Text;
            SSH_Data_Transf.Password = PasswordLine.Text;
            Form f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            SSH_Data_Transf.Adres = AddresLine.Text;
            SSH_Data_Transf.Port = PortLine.Text;
            SSH_Data_Transf.Username = UsernameLine.Text;
            SSH_Data_Transf.Password = PasswordLine.Text;
            Form f = new DaemonList();
            f.Show();
        }
    }
}