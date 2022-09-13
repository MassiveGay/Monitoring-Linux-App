namespace Monitoring
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Connection = new System.Windows.Forms.Button();
            this.AddresLine = new System.Windows.Forms.TextBox();
            this.UsernameLine = new System.Windows.Forms.TextBox();
            this.PasswordLine = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Addres = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TempBox = new System.Windows.Forms.GroupBox();
            this.ConnGroup = new System.Windows.Forms.GroupBox();
            this.PortLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewConn = new System.Windows.Forms.Button();
            this.SystemctlGroup = new System.Windows.Forms.GroupBox();
            this.UpdateCollection = new System.Windows.Forms.Button();
            this.name_list = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.systemctlOut = new System.Windows.Forms.RichTextBox();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DiskInfo = new System.Windows.Forms.ProgressBar();
            this.DiskInfo_group = new System.Windows.Forms.GroupBox();
            this.ftpGroup = new System.Windows.Forms.GroupBox();
            this.ftpPass = new System.Windows.Forms.TextBox();
            this.ftpLog = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.packageInstallgroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.packageNameText = new System.Windows.Forms.TextBox();
            this.Fail2ban_group = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.TempBox.SuspendLayout();
            this.ConnGroup.SuspendLayout();
            this.SystemctlGroup.SuspendLayout();
            this.ControlGroup.SuspendLayout();
            this.DiskInfo_group.SuspendLayout();
            this.ftpGroup.SuspendLayout();
            this.packageInstallgroup.SuspendLayout();
            this.Fail2ban_group.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(589, 465);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(105, 30);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.onConnectClick);
            // 
            // AddresLine
            // 
            this.AddresLine.Location = new System.Drawing.Point(6, 33);
            this.AddresLine.Name = "AddresLine";
            this.AddresLine.Size = new System.Drawing.Size(90, 20);
            this.AddresLine.TabIndex = 2;
            this.AddresLine.TextChanged += new System.EventHandler(this.AddresLine_TextChanged);
            // 
            // UsernameLine
            // 
            this.UsernameLine.Location = new System.Drawing.Point(6, 72);
            this.UsernameLine.Name = "UsernameLine";
            this.UsernameLine.Size = new System.Drawing.Size(131, 20);
            this.UsernameLine.TabIndex = 3;
            // 
            // PasswordLine
            // 
            this.PasswordLine.Location = new System.Drawing.Point(6, 111);
            this.PasswordLine.Name = "PasswordLine";
            this.PasswordLine.PasswordChar = '*';
            this.PasswordLine.Size = new System.Drawing.Size(131, 20);
            this.PasswordLine.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(6, 56);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 5;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(6, 95);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // Addres
            // 
            this.Addres.AutoSize = true;
            this.Addres.Location = new System.Drawing.Point(6, 17);
            this.Addres.Name = "Addres";
            this.Addres.Size = new System.Drawing.Size(40, 13);
            this.Addres.TabIndex = 7;
            this.Addres.Text = "Addres";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(120, 36);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // TempBox
            // 
            this.TempBox.Controls.Add(this.richTextBox1);
            this.TempBox.Location = new System.Drawing.Point(438, 0);
            this.TempBox.Name = "TempBox";
            this.TempBox.Size = new System.Drawing.Size(133, 77);
            this.TempBox.TabIndex = 11;
            this.TempBox.TabStop = false;
            this.TempBox.Text = "Temperature";
            // 
            // ConnGroup
            // 
            this.ConnGroup.Controls.Add(this.PortLine);
            this.ConnGroup.Controls.Add(this.label2);
            this.ConnGroup.Controls.Add(this.AddresLine);
            this.ConnGroup.Controls.Add(this.UsernameLine);
            this.ConnGroup.Controls.Add(this.Addres);
            this.ConnGroup.Controls.Add(this.PasswordLine);
            this.ConnGroup.Controls.Add(this.Password);
            this.ConnGroup.Controls.Add(this.Username);
            this.ConnGroup.Location = new System.Drawing.Point(589, 323);
            this.ConnGroup.Name = "ConnGroup";
            this.ConnGroup.Size = new System.Drawing.Size(143, 138);
            this.ConnGroup.TabIndex = 12;
            this.ConnGroup.TabStop = false;
            this.ConnGroup.Text = "Connection";
            // 
            // PortLine
            // 
            this.PortLine.Location = new System.Drawing.Point(102, 33);
            this.PortLine.Name = "PortLine";
            this.PortLine.Size = new System.Drawing.Size(35, 20);
            this.PortLine.TabIndex = 11;
            this.PortLine.Text = "22";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // NewConn
            // 
            this.NewConn.Enabled = false;
            this.NewConn.Location = new System.Drawing.Point(700, 465);
            this.NewConn.Name = "NewConn";
            this.NewConn.Size = new System.Drawing.Size(32, 30);
            this.NewConn.TabIndex = 8;
            this.NewConn.Text = "+";
            this.NewConn.UseVisualStyleBackColor = true;
            this.NewConn.Click += new System.EventHandler(this.NewConn_Click);
            // 
            // SystemctlGroup
            // 
            this.SystemctlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemctlGroup.Controls.Add(this.UpdateCollection);
            this.SystemctlGroup.Controls.Add(this.name_list);
            this.SystemctlGroup.Controls.Add(this.button4);
            this.SystemctlGroup.Controls.Add(this.button3);
            this.SystemctlGroup.Controls.Add(this.startBtn);
            this.SystemctlGroup.Controls.Add(this.button1);
            this.SystemctlGroup.Controls.Add(this.label1);
            this.SystemctlGroup.Location = new System.Drawing.Point(0, 0);
            this.SystemctlGroup.Name = "SystemctlGroup";
            this.SystemctlGroup.Size = new System.Drawing.Size(343, 77);
            this.SystemctlGroup.TabIndex = 13;
            this.SystemctlGroup.TabStop = false;
            this.SystemctlGroup.Text = "Systemctl control";
            // 
            // UpdateCollection
            // 
            this.UpdateCollection.Location = new System.Drawing.Point(253, 12);
            this.UpdateCollection.Name = "UpdateCollection";
            this.UpdateCollection.Size = new System.Drawing.Size(75, 23);
            this.UpdateCollection.TabIndex = 16;
            this.UpdateCollection.Text = "Update";
            this.UpdateCollection.UseVisualStyleBackColor = true;
            this.UpdateCollection.Click += new System.EventHandler(this.UpdateCollection_Click);
            // 
            // name_list
            // 
            this.name_list.FormattingEnabled = true;
            this.name_list.IntegralHeight = false;
            this.name_list.Location = new System.Drawing.Point(90, 13);
            this.name_list.Name = "name_list";
            this.name_list.Size = new System.Drawing.Size(157, 21);
            this.name_list.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Restart";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onRestartBtnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onStopBtnClick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(90, 41);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.onStartBtnCLick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onStatusBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service name";
            // 
            // systemctlOut
            // 
            this.systemctlOut.Location = new System.Drawing.Point(12, 13);
            this.systemctlOut.Name = "systemctlOut";
            this.systemctlOut.Size = new System.Drawing.Size(720, 304);
            this.systemctlOut.TabIndex = 14;
            this.systemctlOut.Text = "";
            // 
            // ControlGroup
            // 
            this.ControlGroup.Controls.Add(this.button5);
            this.ControlGroup.Controls.Add(this.button2);
            this.ControlGroup.Location = new System.Drawing.Point(349, 0);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(83, 77);
            this.ControlGroup.TabIndex = 15;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "SrvControl";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Shutdown";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ShutdownBtn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Reboot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RebootBtn);
            // 
            // DiskInfo
            // 
            this.DiskInfo.Location = new System.Drawing.Point(9, 32);
            this.DiskInfo.Name = "DiskInfo";
            this.DiskInfo.Size = new System.Drawing.Size(216, 40);
            this.DiskInfo.TabIndex = 16;
            this.DiskInfo.Click += new System.EventHandler(this.DiskUsedProgressBar);
            // 
            // DiskInfo_group
            // 
            this.DiskInfo_group.Controls.Add(this.DiskInfo);
            this.DiskInfo_group.Location = new System.Drawing.Point(0, 80);
            this.DiskInfo_group.Name = "DiskInfo_group";
            this.DiskInfo_group.Size = new System.Drawing.Size(231, 95);
            this.DiskInfo_group.TabIndex = 18;
            this.DiskInfo_group.TabStop = false;
            this.DiskInfo_group.Text = "Disk info";
            // 
            // ftpGroup
            // 
            this.ftpGroup.Controls.Add(this.ftpPass);
            this.ftpGroup.Controls.Add(this.ftpLog);
            this.ftpGroup.Controls.Add(this.button6);
            this.ftpGroup.Location = new System.Drawing.Point(237, 80);
            this.ftpGroup.Name = "ftpGroup";
            this.ftpGroup.Size = new System.Drawing.Size(79, 95);
            this.ftpGroup.TabIndex = 19;
            this.ftpGroup.TabStop = false;
            this.ftpGroup.Text = "Ftp";
            // 
            // ftpPass
            // 
            this.ftpPass.Location = new System.Drawing.Point(6, 38);
            this.ftpPass.Name = "ftpPass";
            this.ftpPass.PasswordChar = '*';
            this.ftpPass.Size = new System.Drawing.Size(67, 20);
            this.ftpPass.TabIndex = 2;
            this.ftpPass.Text = "Password";
            // 
            // ftpLog
            // 
            this.ftpLog.Location = new System.Drawing.Point(6, 16);
            this.ftpLog.Name = "ftpLog";
            this.ftpLog.Size = new System.Drawing.Size(67, 20);
            this.ftpLog.TabIndex = 1;
            this.ftpLog.Text = "Login";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 30);
            this.button6.TabIndex = 0;
            this.button6.Text = "Open";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ftpOpen);
            // 
            // packageInstallgroup
            // 
            this.packageInstallgroup.Controls.Add(this.label3);
            this.packageInstallgroup.Controls.Add(this.button8);
            this.packageInstallgroup.Controls.Add(this.button7);
            this.packageInstallgroup.Controls.Add(this.packageNameText);
            this.packageInstallgroup.Location = new System.Drawing.Point(322, 80);
            this.packageInstallgroup.Name = "packageInstallgroup";
            this.packageInstallgroup.Size = new System.Drawing.Size(122, 95);
            this.packageInstallgroup.TabIndex = 20;
            this.packageInstallgroup.TabStop = false;
            this.packageInstallgroup.Text = "Package install";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Package name";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(59, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.onRemoveButtonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Install";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.onButtonInstallClick);
            // 
            // packageNameText
            // 
            this.packageNameText.Location = new System.Drawing.Point(7, 32);
            this.packageNameText.Name = "packageNameText";
            this.packageNameText.Size = new System.Drawing.Size(107, 20);
            this.packageNameText.TabIndex = 0;
            // 
            // Fail2ban_group
            // 
            this.Fail2ban_group.Controls.Add(this.label4);
            this.Fail2ban_group.Controls.Add(this.button9);
            this.Fail2ban_group.Location = new System.Drawing.Point(450, 80);
            this.Fail2ban_group.Name = "Fail2ban_group";
            this.Fail2ban_group.Size = new System.Drawing.Size(121, 95);
            this.Fail2ban_group.TabIndex = 21;
            this.Fail2ban_group.TabStop = false;
            this.Fail2ban_group.Text = "fail2ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unban on Fail2ban";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(9, 59);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Open";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OpenForm3_Click);
            // 
            // MainGroup
            // 
            this.MainGroup.CausesValidation = false;
            this.MainGroup.Controls.Add(this.SystemctlGroup);
            this.MainGroup.Controls.Add(this.DiskInfo_group);
            this.MainGroup.Controls.Add(this.ftpGroup);
            this.MainGroup.Controls.Add(this.packageInstallgroup);
            this.MainGroup.Controls.Add(this.Fail2ban_group);
            this.MainGroup.Controls.Add(this.ControlGroup);
            this.MainGroup.Controls.Add(this.TempBox);
            this.MainGroup.Enabled = false;
            this.MainGroup.Location = new System.Drawing.Point(12, 323);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(571, 175);
            this.MainGroup.TabIndex = 22;
            this.MainGroup.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 500);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.systemctlOut);
            this.Controls.Add(this.NewConn);
            this.Controls.Add(this.ConnGroup);
            this.Controls.Add(this.Connection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Monitoring";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.TempBox.ResumeLayout(false);
            this.ConnGroup.ResumeLayout(false);
            this.ConnGroup.PerformLayout();
            this.SystemctlGroup.ResumeLayout(false);
            this.SystemctlGroup.PerformLayout();
            this.ControlGroup.ResumeLayout(false);
            this.DiskInfo_group.ResumeLayout(false);
            this.ftpGroup.ResumeLayout(false);
            this.ftpGroup.PerformLayout();
            this.packageInstallgroup.ResumeLayout(false);
            this.packageInstallgroup.PerformLayout();
            this.Fail2ban_group.ResumeLayout(false);
            this.Fail2ban_group.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        

        private System.Windows.Forms.GroupBox MainGroup;

        #endregion

        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.TextBox AddresLine;
        private System.Windows.Forms.TextBox UsernameLine;
        private System.Windows.Forms.TextBox PasswordLine;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Addres;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox TempBox;
        private System.Windows.Forms.GroupBox ConnGroup;
        private System.Windows.Forms.GroupBox SystemctlGroup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox systemctlOut;
        private System.Windows.Forms.ComboBox name_list;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar DiskInfo;
        private System.Windows.Forms.GroupBox DiskInfo_group;
        private System.Windows.Forms.Button NewConn;
        private System.Windows.Forms.GroupBox ftpGroup;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button UpdateCollection;
        private System.Windows.Forms.GroupBox packageInstallgroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox packageNameText;
        private System.Windows.Forms.TextBox ftpPass;
        private System.Windows.Forms.TextBox ftpLog;
        private System.Windows.Forms.GroupBox Fail2ban_group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortLine;
    }
}

