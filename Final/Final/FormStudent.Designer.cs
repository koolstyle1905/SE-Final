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
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPriorityID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.studentDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colStudentID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClassID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRoomID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPlaceOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReligion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCourse = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colClub = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSSN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDtoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
			this.gridSplitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriorityID});
			this.gridView2.GridControl = this.gridControl1;
			this.gridView2.Name = "gridView2";
			// 
			// colPriorityID
			// 
			this.colPriorityID.ColumnEdit = this.repositoryItemComboBox2;
			this.colPriorityID.FieldName = "Content";
			this.colPriorityID.Name = "colPriorityID";
			this.colPriorityID.Visible = true;
			this.colPriorityID.VisibleIndex = 0;
			// 
			// repositoryItemComboBox2
			// 
			this.repositoryItemComboBox2.AutoHeight = false;
			this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.studentDtoBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			gridLevelNode1.LevelTemplate = this.gridView2;
			gridLevelNode1.RelationName = "Priorities";
			this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
			this.gridControl1.ShowOnlyPredefinedDetails = true;
			this.gridControl1.Size = new System.Drawing.Size(1030, 618);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
			// 
			// studentDtoBindingSource
			// 
			this.studentDtoBindingSource.DataSource = typeof(DataTransfer.StudentDto);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStudentID,
            this.colClassID,
            this.colRoomID,
            this.colPlaceOfBirth,
            this.colNation,
            this.colReligion,
            this.colCourse,
            this.colClub,
            this.colName,
            this.colGender,
            this.colDateOfBirth,
            this.colSSN,
            this.colAddress,
            this.colPhone});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
			this.gridView1.OptionsEditForm.EditFormColumnCount = 7;
			this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
			// 
			// colStudentID
			// 
			this.colStudentID.FieldName = "StudentID";
			this.colStudentID.Name = "colStudentID";
			this.colStudentID.Visible = true;
			this.colStudentID.VisibleIndex = 0;
			// 
			// colClassID
			// 
			this.colClassID.FieldName = "ClassID";
			this.colClassID.Name = "colClassID";
			this.colClassID.Visible = true;
			this.colClassID.VisibleIndex = 1;
			// 
			// colRoomID
			// 
			this.colRoomID.FieldName = "RoomID";
			this.colRoomID.Name = "colRoomID";
			this.colRoomID.Visible = true;
			this.colRoomID.VisibleIndex = 2;
			// 
			// colPlaceOfBirth
			// 
			this.colPlaceOfBirth.FieldName = "PlaceOfBirth";
			this.colPlaceOfBirth.Name = "colPlaceOfBirth";
			this.colPlaceOfBirth.OptionsEditForm.VisibleIndex = 3;
			this.colPlaceOfBirth.Visible = true;
			this.colPlaceOfBirth.VisibleIndex = 13;
			// 
			// colNation
			// 
			this.colNation.FieldName = "Nation";
			this.colNation.Name = "colNation";
			this.colNation.OptionsEditForm.VisibleIndex = 2;
			this.colNation.Visible = true;
			this.colNation.VisibleIndex = 11;
			// 
			// colReligion
			// 
			this.colReligion.FieldName = "Religion";
			this.colReligion.Name = "colReligion";
			this.colReligion.OptionsEditForm.VisibleIndex = 2;
			this.colReligion.Visible = true;
			this.colReligion.VisibleIndex = 12;
			// 
			// colCourse
			// 
			this.colCourse.FieldName = "Course";
			this.colCourse.Name = "colCourse";
			this.colCourse.OptionsEditForm.VisibleIndex = 1;
			this.colCourse.Visible = true;
			this.colCourse.VisibleIndex = 9;
			// 
			// colClub
			// 
			this.colClub.Caption = "Câu lạc bộ";
			this.colClub.FieldName = "Club.Name";
			this.colClub.Name = "colClub";
			this.colClub.OptionsEditForm.VisibleIndex = 1;
			this.colClub.Visible = true;
			this.colClub.VisibleIndex = 10;
			// 
			// colName
			// 
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 3;
			// 
			// colGender
			// 
			this.colGender.ColumnEdit = this.repositoryItemComboBox1;
			this.colGender.FieldName = "Gender";
			this.colGender.Name = "colGender";
			this.colGender.Visible = true;
			this.colGender.VisibleIndex = 4;
			// 
			// repositoryItemComboBox1
			// 
			this.repositoryItemComboBox1.AutoHeight = false;
			this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
			// 
			// colDateOfBirth
			// 
			this.colDateOfBirth.FieldName = "DateOfBirth";
			this.colDateOfBirth.Name = "colDateOfBirth";
			this.colDateOfBirth.Visible = true;
			this.colDateOfBirth.VisibleIndex = 5;
			// 
			// colSSN
			// 
			this.colSSN.FieldName = "SSN";
			this.colSSN.Name = "colSSN";
			this.colSSN.Visible = true;
			this.colSSN.VisibleIndex = 6;
			// 
			// colAddress
			// 
			this.colAddress.FieldName = "Address";
			this.colAddress.Name = "colAddress";
			this.colAddress.Visible = true;
			this.colAddress.VisibleIndex = 7;
			// 
			// colPhone
			// 
			this.colPhone.FieldName = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.Visible = true;
			this.colPhone.VisibleIndex = 8;
			// 
			// gridSplitContainer1
			// 
			this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridSplitContainer1.Grid = null;
			this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.gridSplitContainer1.Name = "gridSplitContainer1";
			this.gridSplitContainer1.Size = new System.Drawing.Size(779, 512);
			this.gridSplitContainer1.TabIndex = 0;
			// 
			// FormStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 618);
			this.Controls.Add(this.gridControl1);
			this.Name = "FormStudent";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FormStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDtoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
			this.gridSplitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colStudentID;
		private DevExpress.XtraGrid.Columns.GridColumn colClassID;
		private DevExpress.XtraGrid.Columns.GridColumn colRoomID;
		private DevExpress.XtraGrid.Columns.GridColumn colPlaceOfBirth;
		private DevExpress.XtraGrid.Columns.GridColumn colNation;
		private DevExpress.XtraGrid.Columns.GridColumn colReligion;
		private DevExpress.XtraGrid.Columns.GridColumn colCourse;
		private DevExpress.XtraGrid.Columns.GridColumn colClub;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colGender;
		private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
		private DevExpress.XtraGrid.Columns.GridColumn colSSN;
		private DevExpress.XtraGrid.Columns.GridColumn colAddress;
		private DevExpress.XtraGrid.Columns.GridColumn colPhone;
		private System.Windows.Forms.BindingSource studentDtoBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
		private DevExpress.XtraGrid.Columns.GridColumn colPriorityID;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
	}
}