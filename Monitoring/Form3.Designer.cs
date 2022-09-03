namespace Monitoring {
    partial class Form3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.TableFailBox = new System.Windows.Forms.RichTextBox();
            this.JailDropList = new System.Windows.Forms.ComboBox();
            this.BannedIPlist = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableFailBox
            // 
            this.TableFailBox.Location = new System.Drawing.Point(12, 39);
            this.TableFailBox.Name = "TableFailBox";
            this.TableFailBox.Size = new System.Drawing.Size(178, 152);
            this.TableFailBox.TabIndex = 0;
            this.TableFailBox.Text = "";
            // 
            // JailDropList
            // 
            this.JailDropList.FormattingEnabled = true;
            this.JailDropList.Location = new System.Drawing.Point(12, 12);
            this.JailDropList.Name = "JailDropList";
            this.JailDropList.Size = new System.Drawing.Size(178, 21);
            this.JailDropList.TabIndex = 1;
            // 
            // BannedIPlist
            // 
            this.BannedIPlist.FormattingEnabled = true;
            this.BannedIPlist.Location = new System.Drawing.Point(12, 197);
            this.BannedIPlist.Name = "BannedIPlist";
            this.BannedIPlist.Size = new System.Drawing.Size(178, 21);
            this.BannedIPlist.TabIndex = 2;
            this.BannedIPlist.SelectedIndexChanged += new System.EventHandler(this.BannedIPlist_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Unban";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BannedIPlist);
            this.Controls.Add(this.JailDropList);
            this.Controls.Add(this.TableFailBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Fail2ban";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TableFailBox;
        private System.Windows.Forms.ComboBox JailDropList;
        private System.Windows.Forms.ComboBox BannedIPlist;
        private System.Windows.Forms.Button button1;
    }
}