namespace Final
{
    public partial class FormMain
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
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.barBtnStudentList = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnAddStudent = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonAddStudent = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnLogout = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnRoomList = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnLogin = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnStudentList,
            this.barBtnAddStudent,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonAddStudent,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barBtnLogout,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barBtnRoomList,
            this.barBtnLogin,
            this.barButtonItem5});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 20;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1,
            this.ribbonPage3});
			this.ribbonControl1.Size = new System.Drawing.Size(1244, 168);
			// 
			// barBtnStudentList
			// 
			this.barBtnStudentList.Caption = "Student List";
			this.barBtnStudentList.Id = 1;
			this.barBtnStudentList.ImageUri.Uri = "Home";
			this.barBtnStudentList.Name = "barBtnStudentList";
			this.barBtnStudentList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStudentList_ItemClick);
			// 
			// barBtnAddStudent
			// 
			this.barBtnAddStudent.Caption = "Add Student";
			this.barBtnAddStudent.Id = 2;
			this.barBtnAddStudent.ImageUri.Uri = "Add";
			this.barBtnAddStudent.Name = "barBtnAddStudent";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Refesh";
			this.barButtonItem1.Id = 3;
			this.barButtonItem1.ImageUri.Uri = "Refresh";
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Delete";
			this.barButtonItem2.Id = 4;
			this.barButtonItem2.ImageUri.Uri = "Delete";
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "Save";
			this.barButtonItem3.Id = 5;
			this.barButtonItem3.ImageUri.Uri = "Save";
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// barButtonItem4
			// 
			this.barButtonItem4.Caption = "Print";
			this.barButtonItem4.Id = 6;
			this.barButtonItem4.ImageUri.Uri = "Print";
			this.barButtonItem4.Name = "barButtonItem4";
			// 
			// barButtonAddStudent
			// 
			this.barButtonAddStudent.Caption = "Add";
			this.barButtonAddStudent.Id = 7;
			this.barButtonAddStudent.ImageUri.Uri = "Add";
			this.barButtonAddStudent.Name = "barButtonAddStudent";
			this.barButtonAddStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAddStudent_ItemClick);
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "Undo";
			this.barButtonItem6.Id = 8;
			this.barButtonItem6.ImageUri.Uri = "Undo";
			this.barButtonItem6.Name = "barButtonItem6";
			this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
			// 
			// barButtonItem7
			// 
			this.barButtonItem7.Caption = "Redo";
			this.barButtonItem7.Id = 9;
			this.barButtonItem7.ImageUri.Uri = "Redo";
			this.barButtonItem7.Name = "barButtonItem7";
			this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
			// 
			// barButtonItem8
			// 
			this.barButtonItem8.Caption = "Export Excel";
			this.barButtonItem8.Id = 10;
			this.barButtonItem8.ImageUri.Uri = "ExportToXLSX";
			this.barButtonItem8.Name = "barButtonItem8";
			// 
			// barButtonItem9
			// 
			this.barButtonItem9.Caption = "barButtonItem9";
			this.barButtonItem9.Id = 11;
			this.barButtonItem9.Name = "barButtonItem9";
			// 
			// barButtonItem10
			// 
			this.barButtonItem10.Caption = "Search";
			this.barButtonItem10.Id = 12;
			this.barButtonItem10.ImageUri.Uri = "Zoom";
			this.barButtonItem10.Name = "barButtonItem10";
			// 
			// barButtonItem11
			// 
			this.barButtonItem11.Caption = "Information";
			this.barButtonItem11.Id = 13;
			this.barButtonItem11.ImageUri.Uri = "Clear";
			this.barButtonItem11.Name = "barButtonItem11";
			// 
			// barBtnLogout
			// 
			this.barBtnLogout.Caption = "Log out";
			this.barBtnLogout.Id = 14;
			this.barBtnLogout.ImageUri.Uri = "AlignVerticalCenter";
			this.barBtnLogout.Name = "barBtnLogout";
			// 
			// barButtonItem13
			// 
			this.barButtonItem13.Caption = "Exit";
			this.barButtonItem13.Id = 15;
			this.barButtonItem13.ImageUri.Uri = "Close";
			this.barButtonItem13.Name = "barButtonItem13";
			// 
			// barButtonItem14
			// 
			this.barButtonItem14.Caption = "Export PDF";
			this.barButtonItem14.Id = 16;
			this.barButtonItem14.ImageUri.Uri = "ExportToPDF";
			this.barButtonItem14.Name = "barButtonItem14";
			// 
			// barBtnRoomList
			// 
			this.barBtnRoomList.Caption = "Room List";
			this.barBtnRoomList.Id = 17;
			this.barBtnRoomList.ImageUri.Uri = "Home";
			this.barBtnRoomList.Name = "barBtnRoomList";
			this.barBtnRoomList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick);
			// 
			// barBtnLogin
			// 
			this.barBtnLogin.Caption = "Log in";
			this.barBtnLogin.Id = 18;
			this.barBtnLogin.ImageUri.Uri = "AlignVerticalLeft";
			this.barBtnLogin.Name = "barBtnLogin";
			this.barBtnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLogin_ItemClick);
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "Home";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.barBtnLogin);
			this.ribbonPageGroup2.ItemLinks.Add(this.barBtnLogout);
			this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem11);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Account";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
			this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem13);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "System";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Student";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStudentList);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonAddStudent);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem10);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem7);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Management";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem14);
			this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem8);
			this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "Export";
			// 
			// ribbonPage3
			// 
			this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
			this.ribbonPage3.Name = "ribbonPage3";
			this.ribbonPage3.Text = "Room";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.barBtnRoomList);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "Management";
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.MdiParent = this;
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "Configure";
			this.barButtonItem5.Id = 19;
			this.barButtonItem5.ImageUri.Uri = "ClearFormatting";
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 706);
			this.Controls.Add(this.ribbonControl1);
			this.IsMdiContainer = true;
			this.Name = "FormMain";
			this.Ribbon = this.ribbonControl1;
			this.Text = "FormMain";
			this.Load += new System.EventHandler(this.Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.BarButtonItem barBtnStudentList;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.BarButtonItem barBtnAddStudent;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonAddStudent;
		private DevExpress.XtraBars.BarButtonItem barButtonItem6;
		private DevExpress.XtraBars.BarButtonItem barButtonItem7;
		private DevExpress.XtraBars.BarButtonItem barButtonItem8;
		private DevExpress.XtraBars.BarButtonItem barButtonItem9;
		private DevExpress.XtraBars.BarButtonItem barButtonItem10;
		private DevExpress.XtraBars.BarButtonItem barButtonItem11;
		private DevExpress.XtraBars.BarButtonItem barBtnLogout;
		private DevExpress.XtraBars.BarButtonItem barButtonItem13;
		private DevExpress.XtraBars.BarButtonItem barButtonItem14;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarButtonItem barBtnRoomList;
		private DevExpress.XtraBars.BarButtonItem barBtnLogin;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
	}
}
