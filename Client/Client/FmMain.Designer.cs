namespace Client
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnHome = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowShowToolbarsPopup = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList2;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.btnHome,
            this.barSubItem3,
            this.barSubItem4,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.LargeImages = this.imageList1;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 18;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bar1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            this.bar2.Visible = false;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "操作";
            this.barSubItem1.Id = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "切换用户(&C)";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.ImageIndex = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "修改密码(&M)";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.ImageIndex = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "退出(&C)";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.ImageIndex = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "查询";
            this.barSubItem3.Id = 10;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "查询中心(&Q)";
            this.barButtonItem4.Id = 16;
            this.barButtonItem4.ImageIndex = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "帮助";
            this.barSubItem4.Id = 11;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "关于";
            this.barButtonItem5.Id = 17;
            this.barButtonItem5.ImageIndex = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 4";
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 3";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHome)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.RotateWhenVertical = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 3";
            // 
            // btnHome
            // 
            this.btnHome.Caption = "返回首页(&R)";
            this.btnHome.Id = 8;
            this.btnHome.LargeImageIndex = 2;
            this.btnHome.Name = "btnHome";
            this.btnHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHome_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(878, 90);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 380);
            this.barDockControlBottom.Size = new System.Drawing.Size(878, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 90);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 290);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(878, 90);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 290);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Messenger_01.png");
            this.imageList2.Images.SetKeyName(1, "Lock_04.png");
            this.imageList2.Images.SetKeyName(2, "iCandy Junior Icon 14.png");
            this.imageList2.Images.SetKeyName(3, "Security-1.png");
            this.imageList2.Images.SetKeyName(4, "LOG2.gif");
            this.imageList2.Images.SetKeyName(5, "预览.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "zippo 016.png");
            this.imageList1.Images.SetKeyName(1, "Slayman3.jpg");
            this.imageList1.Images.SetKeyName(2, "back.png");
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // defaultBarAndDockingController1
            // 
            // 
            // 
            // 
            this.defaultBarAndDockingController1.Controller.AppearancesBackstageView.Tab.BackColor = System.Drawing.Color.Black;
            this.defaultBarAndDockingController1.Controller.AppearancesBackstageView.Tab.Options.UseBackColor = true;
            this.defaultBarAndDockingController1.Controller.LookAndFeel.SkinName = "Blue";
            this.defaultBarAndDockingController1.Controller.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabbedMdiManager1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.xtraTabbedMdiManager1.Controller = this.defaultBarAndDockingController1.Controller;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FmMain
            // 
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 403);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FmMain";
            this.Text = "主窗体";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmMain_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.FmMain_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarLargeButtonItem btnHome;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}