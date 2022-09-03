namespace Monitoring {
    partial class Fail2ban {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fail2ban));
            this.TableFailBox = new System.Windows.Forms.RichTextBox();
            this.Unban_btn = new System.Windows.Forms.Button();
            this.JailDropList = new System.Windows.Forms.ComboBox();
            this.BannedIPlist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TableFailBox
            // 
            this.TableFailBox.Location = new System.Drawing.Point(12, 39);
            this.TableFailBox.Name = "TableFailBox";
            this.TableFailBox.Size = new System.Drawing.Size(211, 148);
            this.TableFailBox.TabIndex = 0;
            this.TableFailBox.Text = "";
            // 
            // Unban_btn
            // 
            this.Unban_btn.Location = new System.Drawing.Point(12, 219);
            this.Unban_btn.Name = "Unban_btn";
            this.Unban_btn.Size = new System.Drawing.Size(209, 23);
            this.Unban_btn.TabIndex = 2;
            this.Unban_btn.Text = "Un ban IP";
            this.Unban_btn.UseVisualStyleBackColor = true;
            this.Unban_btn.Click += new System.EventHandler(this.Unban_btn_Click);
            // 
            // JailDropList
            // 
            this.JailDropList.FormattingEnabled = true;
            this.JailDropList.Location = new System.Drawing.Point(12, 12);
            this.JailDropList.Name = "JailDropList";
            this.JailDropList.Size = new System.Drawing.Size(209, 21);
            this.JailDropList.TabIndex = 4;
            // 
            // BannedIPlist
            // 
            this.BannedIPlist.FormattingEnabled = true;
            this.BannedIPlist.Location = new System.Drawing.Point(12, 193);
            this.BannedIPlist.Name = "BannedIPlist";
            this.BannedIPlist.Size = new System.Drawing.Size(209, 21);
            this.BannedIPlist.TabIndex = 5;
            // 
            // Fail2ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 249);
            this.Controls.Add(this.BannedIPlist);
            this.Controls.Add(this.JailDropList);
            this.Controls.Add(this.Unban_btn);
            this.Controls.Add(this.TableFailBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fail2ban";
            this.Text = "Fail2ban";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TableFailBox;
        private System.Windows.Forms.Button Unban_btn;
        private System.Windows.Forms.ComboBox JailDropList;
        private System.Windows.Forms.ComboBox BannedIPlist;
    }
}