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
    public partial class DaemonList : Form
    {
        SshClient ssh;
        public DaemonList()
        {
            InitializeComponent();
            connection();
        }

        public void connection()
        {
            string host = SSH_Data_Transf.Adres;
            int port = int.Parse(SSH_Data_Transf.Port);
            string username = SSH_Data_Transf.Username;
            string password = SSH_Data_Transf.Password;
            ssh = new SshClient(host, port, username, password);
            ssh.Connect();
            var conclusion = ssh.RunCommand("sudo systemctl list-units");
            string[] lines = conclusion.Result.Split(new string[] { "\n" }, StringSplitOptions.None);
            dataGridView1.RowCount = 257;
            dataGridView1.ColumnCount = 6;
            dataGridView1.DataSource = lines;
        }
    }
}