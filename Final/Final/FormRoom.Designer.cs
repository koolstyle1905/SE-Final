namespace Final
{
	partial class FormRoom
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.roomDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colRoomId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNumOfStudent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.treeViewFloor = new System.Windows.Forms.TreeView();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colStudentId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClubId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPlaceOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReligion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCourse = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSsn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomDtoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Controls.Add(this.treeViewFloor);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1207, 516);
			this.panelControl1.TabIndex = 0;
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.roomDtoBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			gridLevelNode1.LevelTemplate = this.gridView2;
			gridLevelNode1.RelationName = "Students";
			this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gridControl1.Location = new System.Drawing.Point(123, 2);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1082, 512);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
			// 
			// roomDtoBindingSource
			// 
			this.roomDtoBindingSource.DataSource = typeof(DataTransfer.RoomDto);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoomId,
            this.colNumOfStudent});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colRoomId
			// 
			this.colRoomId.FieldName = "RoomId";
			this.colRoomId.Name = "colRoomId";
			this.colRoomId.Visible = true;
			this.colRoomId.VisibleIndex = 0;
			// 
			// colNumOfStudent
			// 
			this.colNumOfStudent.FieldName = "NumOfStudent";
			this.colNumOfStudent.Name = "colNumOfStudent";
			this.colNumOfStudent.OptionsColumn.ReadOnly = true;
			this.colNumOfStudent.Visible = true;
			this.colNumOfStudent.VisibleIndex = 1;
			// 
			// treeViewFloor
			// 
			this.treeViewFloor.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeViewFloor.Location = new System.Drawing.Point(2, 2);
			this.treeViewFloor.Name = "treeViewFloor";
			this.treeViewFloor.Size = new System.Drawing.Size(121, 512);
			this.treeViewFloor.TabIndex = 0;
			this.treeViewFloor.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFloor_NodeMouseClick);
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStudentId,
            this.colClubId,
            this.colName,
            this.colGender,
            this.colClass,
            this.colFaculty,
            this.colDateOfBirth,
            this.colCourse,
            this.colAddress,
            this.colPhone,
            this.colSsn,
            this.colNation,
            this.colReligion,
            this.colPlaceOfBirth});
			this.gridView2.GridControl = this.gridControl1;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsBehavior.ReadOnly = true;
			// 
			// colStudentId
			// 
			this.colStudentId.FieldName = "StudentId";
			this.colStudentId.Name = "colStudentId";
			this.colStudentId.Visible = true;
			this.colStudentId.VisibleIndex = 0;
			// 
			// colClass
			// 
			this.colClass.Caption = "Class";
			this.colClass.FieldName = "Class.ClassId";
			this.colClass.Name = "colClass";
			this.colClass.Visible = true;
			this.colClass.VisibleIndex = 4;
			// 
			// colClubId
			// 
			this.colClubId.FieldName = "ClubId";
			this.colClubId.Name = "colClubId";
			this.colClubId.Visible = true;
			this.colClubId.VisibleIndex = 1;
			// 
			// colPlaceOfBirth
			// 
			this.colPlaceOfBirth.FieldName = "PlaceOfBirth";
			this.colPlaceOfBirth.Name = "colPlaceOfBirth";
			this.colPlaceOfBirth.Visible = true;
			this.colPlaceOfBirth.VisibleIndex = 13;
			// 
			// colNation
			// 
			this.colNation.FieldName = "Nation";
			this.colNation.Name = "colNation";
			this.colNation.Visible = true;
			this.colNation.VisibleIndex = 11;
			// 
			// colReligion
			// 
			this.colReligion.FieldName = "Religion";
			this.colReligion.Name = "colReligion";
			this.colReligion.Visible = true;
			this.colReligion.VisibleIndex = 12;
			// 
			// colCourse
			// 
			this.colCourse.FieldName = "Course";
			this.colCourse.Name = "colCourse";
			this.colCourse.Visible = true;
			this.colCourse.VisibleIndex = 7;
			// 
			// colName
			// 
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 2;
			// 
			// colGender
			// 
			this.colGender.FieldName = "Gender";
			this.colGender.Name = "colGender";
			this.colGender.Visible = true;
			this.colGender.VisibleIndex = 3;
			// 
			// colDateOfBirth
			// 
			this.colDateOfBirth.FieldName = "DateOfBirth";
			this.colDateOfBirth.Name = "colDateOfBirth";
			this.colDateOfBirth.Visible = true;
			this.colDateOfBirth.VisibleIndex = 6;
			// 
			// colSsn
			// 
			this.colSsn.FieldName = "Ssn";
			this.colSsn.Name = "colSsn";
			this.colSsn.Visible = true;
			this.colSsn.VisibleIndex = 10;
			// 
			// colAddress
			// 
			this.colAddress.FieldName = "Address";
			this.colAddress.Name = "colAddress";
			this.colAddress.Visible = true;
			this.colAddress.VisibleIndex = 8;
			// 
			// colPhone
			// 
			this.colPhone.FieldName = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.Visible = true;
			this.colPhone.VisibleIndex = 9;
			// 
			// colFaculty
			// 
			this.colFaculty.Caption = "Faculty";
			this.colFaculty.FieldName = "Class.Faculty.Name";
			this.colFaculty.Name = "colFaculty";
			this.colFaculty.Visible = true;
			this.colFaculty.VisibleIndex = 5;
			// 
			// FormRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1207, 516);
			this.Controls.Add(this.panelControl1);
			this.Name = "FormRoom";
			this.Text = "FormRoom";
			this.Load += new System.EventHandler(this.FormRoom_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomDtoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.TreeView treeViewFloor;
		private System.Windows.Forms.BindingSource roomDtoBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colRoomId;
		private DevExpress.XtraGrid.Columns.GridColumn colNumOfStudent;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn colStudentId;
		private DevExpress.XtraGrid.Columns.GridColumn colClass;
		private DevExpress.XtraGrid.Columns.GridColumn colClubId;
		private DevExpress.XtraGrid.Columns.GridColumn colPlaceOfBirth;
		private DevExpress.XtraGrid.Columns.GridColumn colNation;
		private DevExpress.XtraGrid.Columns.GridColumn colReligion;
		private DevExpress.XtraGrid.Columns.GridColumn colCourse;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colGender;
		private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
		private DevExpress.XtraGrid.Columns.GridColumn colSsn;
		private DevExpress.XtraGrid.Columns.GridColumn colAddress;
		private DevExpress.XtraGrid.Columns.GridColumn colPhone;
		private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
	}
}