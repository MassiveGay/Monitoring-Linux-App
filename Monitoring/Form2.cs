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

namespace Monitoring
{
    public partial class Form2 : Form
    {
        SshClient ssh;
        private void Form2_Load(object sender, EventArgs e) {

        }
        public Form2() {
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
            var CPU_model = ssh.RunCommand("cat /proc/cpuinfo | grep 'model name' | uniq");
            CpuModel.Text = $"CPU {CPU_model.Result}";
            var Core = ssh.RunCommand("nproc");
            label4.Text = $"Cores amount: {Core.Result}";
            var OS = ssh.RunCommand("lsb_release -a ");
            OSv.Text = OS.Result;
            var memTotal = ssh.RunCommand("vmstat -s | grep -i 'total memory' | sed 's/ *//'").Result;
            string[] total = memTotal.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string mem = string.Join("\n",
                total.Where(s => s.EndsWith("y")).Select(s => s.Remove(s.IndexOf('K'))));
            int convertTotal = int.Parse(mem) / 1000000;
            MemTot.Text = $"{convertTotal}Gb";
            ssh.Disconnect();

        }
    }   
    
}