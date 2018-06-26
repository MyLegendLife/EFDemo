namespace Client
{
    partial class EditPwd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPwd));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labRegPsd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl2.Controls.Add(this.pictureBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.LookAndFeel.SkinName = "iMaginary";
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.LookAndFeel.UseWindowsXPTheme = true;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(254, 41);
            this.panelControl2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(91, 57);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(160, 21);
            this.txtOldPassword.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(191, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(91, 132);
            this.txtPassword2.MaxLength = 10;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(160, 21);
            this.txtPassword2.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Location = new System.Drawing.Point(125, 159);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定(&S)";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原 密 码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "新 密 码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 84);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labRegPsd);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.txtOldPassword);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.txtPassword2);
            this.panelControl1.Controls.Add(this.btnOk);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.SkinName = "Office 2007 Green";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(258, 187);
            this.panelControl1.TabIndex = 10;
            // 
            // labRegPsd
            // 
            this.labRegPsd.AutoSize = true;
            this.labRegPsd.ForeColor = System.Drawing.Color.Red;
            this.labRegPsd.Location = new System.Drawing.Point(89, 108);
            this.labRegPsd.Name = "labRegPsd";
            this.labRegPsd.Size = new System.Drawing.Size(0, 12);
            this.labRegPsd.TabIndex = 9;
            this.labRegPsd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 187);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPwd";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditPwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label labRegPsd;
    }
}