namespace Client
{
    partial class FmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sbOk = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxOperator = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbOk
            // 
            this.sbOk.Location = new System.Drawing.Point(458, 318);
            this.sbOk.Name = "sbOk";
            this.sbOk.Size = new System.Drawing.Size(75, 23);
            this.sbOk.TabIndex = 0;
            this.sbOk.Text = "确定(&O)";
            this.sbOk.Click += new System.EventHandler(this.sbOk_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(590, 318);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(75, 23);
            this.sbCancel.TabIndex = 1;
            this.sbCancel.Text = "取消(&C)";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(458, 234);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "用户名";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(510, 266);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(155, 21);
            this.txtPwd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(458, 273);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "密码";
            // 
            // cbxOperator
            // 
            this.cbxOperator.FormattingEnabled = true;
            this.cbxOperator.Location = new System.Drawing.Point(510, 227);
            this.cbxOperator.Name = "cbxOperator";
            this.cbxOperator.Size = new System.Drawing.Size(155, 20);
            this.cbxOperator.TabIndex = 4;
            // 
            // FmLogin
            // 
            this.AcceptButton = this.sbOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.登陆_软东2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(946, 494);
            this.Controls.Add(this.cbxOperator);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sbCancel);
            this.Controls.Add(this.sbOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbOk;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbxOperator;
    }
}

