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
			this.barBtnAddStudent = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnRefesh = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnRemoveStudent = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonAddStudent = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnUndo = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnRedo = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnExcel = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnSearch = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnPDF = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnLogin = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnRoomList = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.barBtnStudentList = new DevExpress.XtraBars.BarButtonItem();
			this.barBtnLogout = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnAddStudent,
            this.barBtnRefesh,
            this.barBtnRemoveStudent,
            this.barBtnSave,
            this.barBtnPrint,
            this.barButtonAddStudent,
            this.barBtnUndo,
            this.barBtnRedo,
            this.barBtnExcel,
            this.barButtonItem9,
            this.barBtnSearch,
            this.barButtonItem13,
            this.barBtnPDF,
            this.barBtnLogin,
            this.barButtonItem5,
            this.barBtnRoomList,
            this.barBtnStudentList,
            this.barBtnLogout});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 25;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1,
            this.ribbonPage3});
			this.ribbonControl1.Size = new System.Drawing.Size(1244, 168);
			// 
			// barBtnAddStudent
			// 
			this.barBtnAddStudent.Caption = "Add Student";
			this.barBtnAddStudent.Id = 2;
			this.barBtnAddStudent.ImageUri.Uri = "Add";
			this.barBtnAddStudent.Name = "barBtnAddStudent";
			// 
			// barBtnRefesh
			// 
			this.barBtnRefesh.Caption = "Refesh";
			this.barBtnRefesh.Id = 3;
			this.barBtnRefesh.ImageUri.Uri = "Refresh";
			this.barBtnRefesh.Name = "barBtnRefesh";
			// 
			// barBtnRemoveStudent
			// 
			this.barBtnRemoveStudent.Caption = "Remove";
			this.barBtnRemoveStudent.Id = 4;
			this.barBtnRemoveStudent.ImageUri.Uri = "Delete";
			this.barBtnRemoveStudent.Name = "barBtnRemoveStudent";
			// 
			// barBtnSave
			// 
			this.barBtnSave.Caption = "Save";
			this.barBtnSave.Id = 5;
			this.barBtnSave.ImageUri.Uri = "Save";
			this.barBtnSave.Name = "barBtnSave";
			// 
			// barBtnPrint
			// 
			this.barBtnPrint.Caption = "Print";
			this.barBtnPrint.Id = 6;
			this.barBtnPrint.ImageUri.Uri = "Print";
			this.barBtnPrint.Name = "barBtnPrint";
			// 
			// barButtonAddStudent
			// 
			this.barButtonAddStudent.Caption = "Add";
			this.barButtonAddStudent.Id = 7;
			this.barButtonAddStudent.ImageUri.Uri = "Add";
			this.barButtonAddStudent.Name = "barButtonAddStudent";
			this.barButtonAddStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAddStudent_ItemClick);
			// 
			// barBtnUndo
			// 
			this.barBtnUndo.Caption = "Undo";
			this.barBtnUndo.Id = 8;
			this.barBtnUndo.ImageUri.Uri = "Undo";
			this.barBtnUndo.Name = "barBtnUndo";
			this.barBtnUndo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
			// 
			// barBtnRedo
			// 
			this.barBtnRedo.Caption = "Redo";
			this.barBtnRedo.Id = 9;
			this.barBtnRedo.ImageUri.Uri = "Redo";
			this.barBtnRedo.Name = "barBtnRedo";
			this.barBtnRedo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
			// 
			// barBtnExcel
			// 
			this.barBtnExcel.Caption = "Export Excel";
			this.barBtnExcel.Id = 10;
			this.barBtnExcel.ImageUri.Uri = "ExportToXLSX";
			this.barBtnExcel.Name = "barBtnExcel";
			// 
			// barButtonItem9
			// 
			this.barButtonItem9.Caption = "barButtonItem9";
			this.barButtonItem9.Id = 11;
			this.barButtonItem9.Name = "barButtonItem9";
			// 
			// barBtnSearch
			// 
			this.barBtnSearch.Caption = "Search";
			this.barBtnSearch.Id = 12;
			this.barBtnSearch.ImageUri.Uri = "Zoom";
			this.barBtnSearch.Name = "barBtnSearch";
			// 
			// barButtonItem13
			// 
			this.barButtonItem13.Caption = "Exit";
			this.barButtonItem13.Id = 15;
			this.barButtonItem13.ImageUri.Uri = "Close";
			this.barButtonItem13.Name = "barButtonItem13";
			// 
			// barBtnPDF
			// 
			this.barBtnPDF.Caption = "Export PDF";
			this.barBtnPDF.Id = 16;
			this.barBtnPDF.ImageUri.Uri = "ExportToPDF";
			this.barBtnPDF.Name = "barBtnPDF";
			// 
			// barBtnLogin
			// 
			this.barBtnLogin.Id = 20;
			this.barBtnLogin.Name = "barBtnLogin";
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Id = 21;
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// barBtnRoomList
			// 
			this.barBtnRoomList.Caption = "Room List";
			this.barBtnRoomList.Id = 22;
			this.barBtnRoomList.Name = "barBtnRoomList";
			this.barBtnRoomList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRoomList_ItemClick);
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
			this.ribbonPageGroup2.ItemLinks.Add(this.barBtnLogout);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Account";
			// 
			// ribbonPageGroup3
			// 
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
			this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRefesh);
			this.ribbonPageGroup1.ItemLinks.Add(this.barButtonAddStudent);
			this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRemoveStudent);
			this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSearch);
			this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSave);
			this.ribbonPageGroup1.ItemLinks.Add(this.barBtnUndo);
			this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRedo);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Management";
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.barBtnPDF);
			this.ribbonPageGroup4.ItemLinks.Add(this.barBtnExcel);
			this.ribbonPageGroup4.ItemLinks.Add(this.barBtnPrint);
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
			// barBtnStudentList
			// 
			this.barBtnStudentList.Caption = "Student List";
			this.barBtnStudentList.Id = 23;
			this.barBtnStudentList.Name = "barBtnStudentList";
			this.barBtnStudentList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStudentList_ItemClick);
			// 
			// barBtnLogout
			// 
			this.barBtnLogout.Caption = "logout";
			this.barBtnLogout.Id = 24;
			this.barBtnLogout.Name = "barBtnLogout";
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
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private DevExpress.XtraBars.BarButtonItem barBtnAddStudent;
		private DevExpress.XtraBars.BarButtonItem barBtnRefesh;
		private DevExpress.XtraBars.BarButtonItem barBtnRemoveStudent;
		private DevExpress.XtraBars.BarButtonItem barBtnSave;
		private DevExpress.XtraBars.BarButtonItem barBtnPrint;
		private DevExpress.XtraBars.BarButtonItem barButtonAddStudent;
		private DevExpress.XtraBars.BarButtonItem barBtnUndo;
		private DevExpress.XtraBars.BarButtonItem barBtnRedo;
		private DevExpress.XtraBars.BarButtonItem barBtnExcel;
		private DevExpress.XtraBars.BarButtonItem barButtonItem9;
		private DevExpress.XtraBars.BarButtonItem barBtnSearch;
		private DevExpress.XtraBars.BarButtonItem barButtonItem13;
		private DevExpress.XtraBars.BarButtonItem barBtnPDF;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.BarButtonItem barBtnLogin;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.BarButtonItem barBtnRoomList;
		private DevExpress.XtraBars.BarButtonItem barBtnStudentList;
		private DevExpress.XtraBars.BarButtonItem barBtnLogout;
	}
}
