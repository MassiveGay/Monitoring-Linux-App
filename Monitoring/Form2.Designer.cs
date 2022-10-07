using System.ComponentModel;

namespace Monitoring
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CpuModel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MemTot = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OSv = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CpuModel
            // 
            this.CpuModel.Location = new System.Drawing.Point(6, 16);
            this.CpuModel.Name = "CpuModel";
            this.CpuModel.Size = new System.Drawing.Size(392, 14);
            this.CpuModel.TabIndex = 0;
            this.CpuModel.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total RAM:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cores amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CpuModel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MemTot);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM";
            // 
            // MemTot
            // 
            this.MemTot.Location = new System.Drawing.Point(6, 34);
            this.MemTot.Name = "MemTot";
            this.MemTot.Size = new System.Drawing.Size(117, 47);
            this.MemTot.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OSv);
            this.groupBox3.Location = new System.Drawing.Point(147, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OS";
            // 
            // OSv
            // 
            this.OSv.Location = new System.Drawing.Point(6, 16);
            this.OSv.Name = "OSv";
            this.OSv.Size = new System.Drawing.Size(257, 65);
            this.OSv.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(430, 155);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "System information";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label OSv;
        private System.Windows.Forms.Label MemTot;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label CpuModel;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}