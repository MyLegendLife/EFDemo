using Client.BLL;
using Client.Common;
using Client.Model;
using Client.Model.Common;
using Client.Model.Sys;
using ClientManage;
using LoadManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
            AnimateMyWindow.ShowWindowForAnimate(Handle, 500, (int)Dwflag.AW_VER_POSITIVE);
        }

        protected override void OnResize(System.EventArgs e)
        {
            this.Region = null;
            new SetWindowRegion(this);
        }

        List<Operator> operatorData = null;
        private void FmLogin_Load(object sender, EventArgs e)
        {
            OperatorService os = new OperatorService();
            operatorData = os.LoadEntities(c => true).ToList();
            cbxOperator.DataSource = operatorData;
            cbxOperator.DisplayMember = "CODENO";
            cbxOperator.ValueMember = "OPERATORID";
            cbxOperator.Focus();
        }

        private void sbOk_Click(object sender, EventArgs e)
        {
            Operator op = operatorData.Where<Operator>(c => c.CodeNo == cbxOperator.Text.Trim() && c.Password == txtPwd.Text.Trim()).FirstOrDefault();
            if (op == null)
            {
                MsgBox.MsgInfo("用户名或密码错误！");
                return;
            }

            SysOperatorInfo.OperatorID = op.Operatorid;
            SysOperatorInfo.OperatorName = op.OperatorName;
            SysOperatorInfo.OperatorCode = op.CodeNo;

            this.DialogResult = DialogResult.OK;
        }
    }
}
