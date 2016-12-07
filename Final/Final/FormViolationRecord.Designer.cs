namespace Final
{
	partial class FormViolationRecord
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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.violationRecordDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colViolationId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStudent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.violationRecordDtoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.violationRecordDtoBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(630, 523);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// violationRecordDtoBindingSource
			// 
			this.violationRecordDtoBindingSource.DataSource = typeof(DataTransfer.ViolationRecordDto);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colViolationId,
            this.colEmployeeId,
            this.colDescription,
            this.colCreatedDate,
            this.gridColumn1,
            this.gridColumn2,
            this.colStudent,
            this.gridColumn3});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colViolationId
			// 
			this.colViolationId.FieldName = "ViolationId";
			this.colViolationId.Name = "colViolationId";
			this.colViolationId.Visible = true;
			this.colViolationId.VisibleIndex = 0;
			// 
			// colEmployeeId
			// 
			this.colEmployeeId.FieldName = "EmployeeId";
			this.colEmployeeId.Name = "colEmployeeId";
			this.colEmployeeId.Visible = true;
			this.colEmployeeId.VisibleIndex = 1;
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.FieldName = "CreatedDate";
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.Visible = true;
			this.colCreatedDate.VisibleIndex = 3;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Student Id";
			this.gridColumn1.FieldName = "Student.StudentId";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 4;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Room Id";
			this.gridColumn2.FieldName = "Student.RoomId";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 5;
			// 
			// colStudent
			// 
			this.colStudent.Caption = "Student Name";
			this.colStudent.FieldName = "Student.Name";
			this.colStudent.Name = "colStudent";
			this.colStudent.Visible = true;
			this.colStudent.VisibleIndex = 7;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Gender";
			this.gridColumn3.FieldName = "Student.Gender";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 6;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 523);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form2";
			this.Text = "FormViolationRecord";
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.violationRecordDtoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.BindingSource violationRecordDtoBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colViolationId;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn colStudent;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
	}
}