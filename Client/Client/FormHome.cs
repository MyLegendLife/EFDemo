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
    public partial class FormHome : BaseForm
    {
        List<OperatorMenuAuthority> operatorMenu = null;
        private FmMain fmMain;

        public FormHome()
        {
            InitializeComponent();
            this.barPublic = this.bar1;
        }

        public FormHome(FmMain fmMain)
        {
            InitializeComponent();
            this.fmMain = fmMain;
            this.barPublic = this.bar1;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            new Action(() =>
            {
                Invoke(new Action(() =>
                {
                    string pluginName;
                    string nodeName;
                    OperatorMenuAuthorityService operatorMenuAuthority = new OperatorMenuAuthorityService();
                    MenuService menuService = new MenuService();
                    if (SysOperatorInfo.OperatorID == "administrator")
                    {
                        //    pluginName = "";
                        //    nodeName = "系统管理";

                        //    DevExpress.XtraNavBar.NavBarItem navBarItem = new DevExpress.XtraNavBar.NavBarItem(nodeName);
                        //    nBControlTree.Items.Add(navBarItem);
                        //    navBarGroup1.ItemLinks.Add(navBarItem);
                        //    navBarItem.Tag = null;
                        //    navBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(navBarItem_LinkClicked);
                        //    Application.DoEvents();
                    }
                    else
                    {
                        operatorMenu = operatorMenuAuthority.LoadEntities(c => c.Operatorid == SysOperatorInfo.OperatorID).ToList();
                        navBarGroup1.ItemLinks.Clear();

                        foreach (var item in operatorMenu)
                        {
                            if (item.ParentNode == "00")
                            {
                                pluginName = item.Menu.Pluginid;
                                nodeName = item.Menu.NodeName;

                                DevExpress.XtraNavBar.NavBarItem navBarItem = new DevExpress.XtraNavBar.NavBarItem(nodeName);
                                nBControlTree.Items.Add(navBarItem);
                                navBarGroup1.ItemLinks.Add(navBarItem);
                                navBarItem.Tag = item.Menu;
                                navBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(navBarItem_LinkClicked);
                                Application.DoEvents();
                            }
                        }
                    }
                }
                   ));
            }).BeginInvoke(
           new AsyncCallback(
               delegate(IAsyncResult iAsyncResult)
               {
                   if (iAsyncResult.IsCompleted)
                   {
                       Invoke(new Action(() =>
                       {
                           if (navBarGroup1.ItemLinks.Count > 0)
                               navBarItem_LinkClicked(null, new DevExpress.XtraNavBar.NavBarLinkEventArgs(navBarGroup1.ItemLinks[0]));
                       }
                           ));
                   }
               }), null);
        }


        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            lstVItem.Items.Clear();
            string pluginName;
            string nodeName;

            Model.Menu menu = null;
            if (e.Link.Item.Tag != null)
            {
                menu = e.Link.Item.Tag as Model.Menu;
                if (menu.Pluginid != string.Empty && menu.isEndNode == "是")
                {
                    pluginName = menu.Pluginid;
                    nodeName = menu.isEndNode;
                    lstVItem.Items.Add(nodeName, 0).Tag = pluginName;
                }
                else
                {
                    foreach (var m in operatorMenu.Where(c => c.ParentNode == menu.Nodeid).OrderBy(c => c.Menu.Disporder))
                    {
                        pluginName = m.Menu.Pluginid;
                        nodeName = m.Menu.NodeName;
                        lstVItem.Items.Add(nodeName, 0).Tag = pluginName;
                    }
                }
            }
            else
            {
                pluginName = "RDBaseSys.FrmMain,RDBaseSys";
                nodeName = "基础数据维护";
                lstVItem.Items.Add(nodeName, 0).Tag = pluginName;
            }

            if (lstVItem.Items.Count > 0)
                lstVItem.Items[0].Selected = true;
        }

        private void nBControlTree_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            DevExpress.XtraNavBar.NavBarHitInfo hi = nBControlTree.CalcHitInfo(p);
            if (hi.InGroupCaption && !hi.InGroupButton)
            {
                hi.Group.Expanded = !hi.Group.Expanded;
            }
        }

        private void lstVItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bool flag = false;

            string LoadClass = lstVItem.SelectedItems[0].Tag.ToString();
            string formName = LoadClass.Split(',', '.')[LoadClass.Split('.').Length - 1];
            string pluginName = LoadClass.Split(',')[1];

            try
            {
                for (int i = 0; i < this.MdiParent.MdiChildren.Length; i++)
                {
                    if (this.MdiParent.MdiChildren[i].Name.ToString().ToLower() == formName.ToLower())
                    {
                        this.MdiParent.MdiChildren[i].Activate();
                        this.MdiParent.MdiChildren[i].Show();
                        this.MdiParent.MdiChildren[i].WindowState = FormWindowState.Normal;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {

                    object Object = Activator.CreateInstance(Type.GetType(lstVItem.SelectedItems[0].Tag.ToString()));
                    Form frmtmp = Object as Form;
                    //if ((frmtmp as FormCls).IsOutFrm)
                    //{
                    //    FrmBaseOutChild frmBaseOutChild = new FrmBaseOutChild();
                    //    frmBaseOutChild.Name = frmtmp.Name;
                    //    frmBaseOutChild.Text = frmtmp.Text;
                    //    frmBaseOutChild.MdiParent = this.MdiParent;
                    //    frmBaseOutChild.ChildFrm = frmtmp as BaseFormCls;
                    //    frmBaseOutChild.Show();
                    //}
                    //else
                    //{
                    frmtmp.MdiParent = this.MdiParent;
                    frmtmp.Show();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("组件加载失败:" + ex.Message);
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void nbiExit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditPwd_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            EditPwd pwd = new EditPwd();
            if (pwd.ShowDialog() == DialogResult.OK)
            {
                MsgBox.MsgInfo("密码修改成功！");
            }
        }

        private void btnChangeUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FmLogin fmLogin = new FmLogin();
            if (fmLogin.ShowDialog() == DialogResult.OK)
            {
                Init();
                if (fmMain != null)
                    fmMain.Init(operatorMenu);
            }


        }
    }
}
