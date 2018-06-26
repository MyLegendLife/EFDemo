namespace Client
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnOpen = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.nBControlTree = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnQuery = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnChangeUser = new DevExpress.XtraNavBar.NavBarItem();
            this.btnEditPwd = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiExit = new DevExpress.XtraNavBar.NavBarItem();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lstVItem = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBControlTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnOpen,
            this.btnHelp,
            this.btnExit});
            this.barManager1.LargeImages = this.imageList4;
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHelp),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.Text = "Tools";
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "打开(&O)";
            this.btnOpen.Id = 0;
            this.btnOpen.LargeImageIndex = 2;
            this.btnOpen.Name = "btnOpen";
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "帮助(&H)";
            this.btnHelp.Id = 1;
            this.btnHelp.LargeImageIndex = 1;
            this.btnHelp.Name = "btnHelp";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "退出(&C)";
            this.btnExit.Id = 2;
            this.btnExit.LargeImageIndex = 0;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(792, 62);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 465);
            this.barDockControlBottom.Size = new System.Drawing.Size(792, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(792, 62);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 403);
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.White;
            this.imageList4.Images.SetKeyName(0, "退出.PNG");
            this.imageList4.Images.SetKeyName(1, "帮助.png");
            this.imageList4.Images.SetKeyName(2, "打开.png");
            // 
            // nBControlTree
            // 
            this.nBControlTree.ActiveGroup = this.navBarGroup1;
            this.nBControlTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nBControlTree.ExplorerBarGroupInterval = 15;
            this.nBControlTree.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.nBControlTree.HotTrackedGroupCursor = System.Windows.Forms.Cursors.Hand;
            this.nBControlTree.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnQuery,
            this.btnEditPwd,
            this.nbiExit,
            this.btnChangeUser});
            this.nBControlTree.Location = new System.Drawing.Point(0, 0);
            this.nBControlTree.LookAndFeel.SkinName = "Blue";
            this.nBControlTree.LookAndFeel.UseDefaultLookAndFeel = false;
            this.nBControlTree.Name = "nBControlTree";
            this.nBControlTree.OptionsNavPane.ExpandedWidth = 217;
            this.nBControlTree.Size = new System.Drawing.Size(175, 403);
            this.nBControlTree.SmallImages = this.imageList3;
            this.nBControlTree.TabIndex = 4;
            this.nBControlTree.Text = "navBarControl1";
            this.nBControlTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nBControlTree_MouseClick);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "工作任务";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "查询任务";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnQuery)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnQuery
            // 
            this.btnQuery.Caption = "查询中心";
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.SmallImageIndex = 5;
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "其他任务";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnChangeUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnEditPwd),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiExit)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Caption = "切换用户";
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.SmallImageIndex = 0;
            this.btnChangeUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnChangeUser_LinkClicked);
            // 
            // btnEditPwd
            // 
            this.btnEditPwd.Caption = "修改密码";
            this.btnEditPwd.Name = "btnEditPwd";
            this.btnEditPwd.SmallImageIndex = 1;
            this.btnEditPwd.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnEditPwd_LinkClicked);
            // 
            // nbiExit
            // 
            this.nbiExit.Caption = "退出系统";
            this.nbiExit.Name = "nbiExit";
            this.nbiExit.SmallImageIndex = 2;
            this.nbiExit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiExit_LinkClicked);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Messenger_01.png");
            this.imageList3.Images.SetKeyName(1, "Lock_04.png");
            this.imageList3.Images.SetKeyName(2, "iCandy Junior Icon 14.png");
            this.imageList3.Images.SetKeyName(3, "Security-1.png");
            this.imageList3.Images.SetKeyName(4, "LOG2.gif");
            this.imageList3.Images.SetKeyName(5, "预览.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Run-3.png");
            this.imageList1.Images.SetKeyName(1, "messenger-1.png");
            this.imageList1.Images.SetKeyName(2, "Run-11.png");
            this.imageList1.Images.SetKeyName(3, "Word doc.png");
            this.imageList1.Images.SetKeyName(4, "Woa22.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "LightSalmon.png");
            this.imageList2.Images.SetKeyName(1, "doc_yellow_exec.png");
            this.imageList2.Images.SetKeyName(2, "Hein84.jpg");
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 62);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.nBControlTree);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.lstVItem);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(792, 403);
            this.splitContainerControl1.SplitterPosition = 175;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lstVItem
            // 
            this.lstVItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVItem.LargeImageList = this.imageList2;
            this.lstVItem.Location = new System.Drawing.Point(0, 0);
            this.lstVItem.Name = "lstVItem";
            this.lstVItem.Size = new System.Drawing.Size(612, 403);
            this.lstVItem.SmallImageList = this.imageList1;
            this.lstVItem.TabIndex = 0;
            this.lstVItem.UseCompatibleStateImageBehavior = false;
            this.lstVItem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVItem_MouseDoubleClick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 465);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "起始页";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBControlTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnOpen;
        private DevExpress.XtraBars.BarLargeButtonItem btnHelp;
        private DevExpress.XtraBars.BarLargeButtonItem btnExit;
        private DevExpress.XtraNavBar.NavBarControl nBControlTree;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem btnQuery;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem btnEditPwd;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ListView lstVItem;
        private DevExpress.XtraNavBar.NavBarItem nbiExit;
        private DevExpress.XtraNavBar.NavBarItem btnChangeUser;
    }
}