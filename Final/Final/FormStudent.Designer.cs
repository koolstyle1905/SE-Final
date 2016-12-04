namespace Final
{
	partial class FormStudent
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
			this.gridViewPriorities = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPriorityId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colContent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.studentDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridViewStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colStudentId = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.colClubId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridViewPriorities)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDtoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridViewPriorities
			// 
			this.gridViewPriorities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriorityId,
            this.colContent});
			this.gridViewPriorities.GridControl = this.gridControl1;
			this.gridViewPriorities.Name = "gridViewPriorities";
			// 
			// colPriorityId
			// 
			this.colPriorityId.FieldName = "PriorityId";
			this.colPriorityId.Name = "colPriorityId";
			this.colPriorityId.Visible = true;
			this.colPriorityId.VisibleIndex = 0;
			// 
			// colContent
			// 
			this.colContent.FieldName = "Content";
			this.colContent.Name = "colContent";
			this.colContent.Visible = true;
			this.colContent.VisibleIndex = 1;
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.studentDtoBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			gridLevelNode1.LevelTemplate = this.gridViewPriorities;
			gridLevelNode1.RelationName = "Priorities";
			gridLevelNode2.RelationName = "Carers";
			this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
			this.gridControl1.Location = new System.Drawing.Point(2, 2);
			this.gridControl1.MainView = this.gridViewStudent;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1202, 705);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStudent,
            this.gridViewPriorities});
			// 
			// studentDtoBindingSource
			// 
			this.studentDtoBindingSource.DataSource = typeof(DataTransfer.StudentDto);
			// 
			// gridViewStudent
			// 
			this.gridViewStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStudentId,
            this.colPlaceOfBirth,
            this.colNation,
            this.colReligion,
            this.colCourse,
            this.colName,
            this.colGender,
            this.colDateOfBirth,
            this.colSsn,
            this.colAddress,
            this.colPhone,
            this.colClubId});
			this.gridViewStudent.GridControl = this.gridControl1;
			this.gridViewStudent.Name = "gridViewStudent";
			this.gridViewStudent.OptionsEditForm.EditFormColumnCount = 6;
			this.gridViewStudent.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewStudent_RowUpdated);
			// 
			// colStudentId
			// 
			this.colStudentId.FieldName = "StudentId";
			this.colStudentId.Name = "colStudentId";
			this.colStudentId.Visible = true;
			this.colStudentId.VisibleIndex = 0;
			// 
			// colPlaceOfBirth
			// 
			this.colPlaceOfBirth.FieldName = "PlaceOfBirth";
			this.colPlaceOfBirth.Name = "colPlaceOfBirth";
			this.colPlaceOfBirth.OptionsEditForm.VisibleIndex = 10;
			this.colPlaceOfBirth.Visible = true;
			this.colPlaceOfBirth.VisibleIndex = 10;
			// 
			// colNation
			// 
			this.colNation.FieldName = "Nation";
			this.colNation.Name = "colNation";
			this.colNation.OptionsEditForm.VisibleIndex = 9;
			this.colNation.Visible = true;
			this.colNation.VisibleIndex = 9;
			// 
			// colReligion
			// 
			this.colReligion.FieldName = "Religion";
			this.colReligion.Name = "colReligion";
			this.colReligion.OptionsEditForm.VisibleIndex = 11;
			this.colReligion.Visible = true;
			this.colReligion.VisibleIndex = 11;
			// 
			// colCourse
			// 
			this.colCourse.FieldName = "Course";
			this.colCourse.Name = "colCourse";
			this.colCourse.OptionsEditForm.VisibleIndex = 3;
			this.colCourse.Visible = true;
			this.colCourse.VisibleIndex = 4;
			// 
			// colName
			// 
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.OptionsEditForm.VisibleIndex = 2;
			this.colName.Visible = true;
			this.colName.VisibleIndex = 2;
			// 
			// colGender
			// 
			this.colGender.FieldName = "Gender";
			this.colGender.Name = "colGender";
			this.colGender.OptionsEditForm.VisibleIndex = 2;
			this.colGender.Visible = true;
			this.colGender.VisibleIndex = 3;
			// 
			// colDateOfBirth
			// 
			this.colDateOfBirth.FieldName = "DateOfBirth";
			this.colDateOfBirth.Name = "colDateOfBirth";
			this.colDateOfBirth.OptionsEditForm.VisibleIndex = 4;
			this.colDateOfBirth.Visible = true;
			this.colDateOfBirth.VisibleIndex = 5;
			// 
			// colSsn
			// 
			this.colSsn.FieldName = "Ssn";
			this.colSsn.Name = "colSsn";
			this.colSsn.OptionsEditForm.VisibleIndex = 8;
			this.colSsn.Visible = true;
			this.colSsn.VisibleIndex = 7;
			// 
			// colAddress
			// 
			this.colAddress.FieldName = "Address";
			this.colAddress.Name = "colAddress";
			this.colAddress.OptionsEditForm.VisibleIndex = 7;
			this.colAddress.Visible = true;
			this.colAddress.VisibleIndex = 6;
			// 
			// colPhone
			// 
			this.colPhone.FieldName = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.OptionsEditForm.VisibleIndex = 8;
			this.colPhone.Visible = true;
			this.colPhone.VisibleIndex = 8;
			// 
			// colClubId
			// 
			this.colClubId.Caption = "Club Id";
			this.colClubId.FieldName = "ClubId";
			this.colClubId.Name = "colClubId";
			this.colClubId.OptionsEditForm.VisibleIndex = 1;
			this.colClubId.Visible = true;
			this.colClubId.VisibleIndex = 1;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1206, 709);
			this.panelControl1.TabIndex = 1;
			// 
			// FormStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1206, 709);
			this.Controls.Add(this.panelControl1);
			this.Name = "FormStudent";
			this.Text = "FormStudent";
			this.Load += new System.EventHandler(this.FormStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridViewPriorities)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDtoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudent;
		private System.Windows.Forms.BindingSource studentDtoBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewPriorities;
		private DevExpress.XtraGrid.Columns.GridColumn colPriorityId;
		private DevExpress.XtraGrid.Columns.GridColumn colContent;
		private DevExpress.XtraGrid.Columns.GridColumn colStudentId;
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
		private DevExpress.XtraGrid.Columns.GridColumn colClubId;
	}
}