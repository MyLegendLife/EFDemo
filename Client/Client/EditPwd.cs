using Client.BLL;
using Client.Common;
using Client.Model;
using Client.Model.Common;
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
    public partial class EditPwd : Form
    {
        Operator oldOperator;
        public EditPwd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (oldOperator.Password != txtOldPassword.Text.Trim())
            {
                msg += "用户名或密码错误！\r\n";
            }
            if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
            {
                msg += "两次密码不一致！\r\n";
            }
            if (msg != "")
            {
                MsgBox.MsgInfo(msg);
                return;
            }
            oldOperator.Password = txtPassword.Text.Trim();
            new OperatorService().EditEntity(oldOperator);
            this.DialogResult = DialogResult.OK;
        }

        private void EditPwd_Load(object sender, EventArgs e)
        {
            oldOperator = new OperatorService().LoadEntities(c => c.Operatorid == SysOperatorInfo.OperatorID).FirstOrDefault();
        }
    }
}
