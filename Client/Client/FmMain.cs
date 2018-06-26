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
    public partial class FmMain : DevExpress.XtraEditors.XtraForm
    {
        internal FormHome frm = null;
        public FmMain()
        {
            InitializeComponent();

            frm = new FormHome(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void FmMain_MdiChildActivate(object sender, EventArgs e)
        {
            Init(null);
        }

        public void Init(List<OperatorMenuAuthority> oma)
        {
            if (this.ActiveMdiChild == null)
                return;
            if ((ActiveMdiChild as BaseForm) == null || (ActiveMdiChild as BaseForm).barPublic == null)
                return;
            bar3.UnMerge();
            (ActiveMdiChild as BaseForm).barPublic.Visible = false;
            bar3.Merge((ActiveMdiChild as BaseForm).barPublic);

            if (bar3.ItemLinks.Count > 0)
                bar3.Visible = true;
            else
                bar3.Visible = false;

            this.Text = "[" + SysOperatorInfo.OperatorCode + "]" + SysOperatorInfo.OperatorName + "-" + ActiveMdiChild.Text;

            if (oma != null)
                //检查当前打开窗口是否属于当前权限，不属于则关闭
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Name.ToString().ToLower() != "FormHome".ToLower() &&
                        oma.Where(w => w.Menu.ToString().ToLower().Contains(this.MdiChildren[i].Name.ToString().ToLower())).Count() <= 0)
                    {
                        this.MdiChildren[i].Close();
                    }
                }

        }

        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MsgBox.MsgInfo("确定退出系统吗?", true))
            {
                e.Cancel = true;
                return;
            }
        }

        // 返回首页
        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool flag = false;

            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name.ToString().ToLower() == "FormHome".ToLower())
                {
                    this.MdiChildren[i].Activate();
                    this.MdiChildren[i].Show();
                    this.MdiChildren[i].WindowState = FormWindowState.Normal;
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                frm = new FormHome();
                frm.MdiParent = this;
                frm.Show();
            }
        }

    }
}
