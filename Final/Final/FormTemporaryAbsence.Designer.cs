namespace Final
{
	partial class FormTemporaryAbsence
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
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.temporaryAbsenceDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colAbsenceId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNumOfAbsence = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStudent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.temporaryAbsenceDtoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.temporaryAbsenceDtoBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(721, 518);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAbsenceId,
            this.colStartDate,
            this.colNumOfAbsence,
            this.colCreatedDate,
            this.colDescription,
            this.colStudent,
            this.gridColumn2,
            this.gridColumn1});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// temporaryAbsenceDtoBindingSource
			// 
			this.temporaryAbsenceDtoBindingSource.DataSource = typeof(DataTransfer.TemporaryAbsenceDto);
			// 
			// colAbsenceId
			// 
			this.colAbsenceId.FieldName = "AbsenceId";
			this.colAbsenceId.Name = "colAbsenceId";
			this.colAbsenceId.Visible = true;
			this.colAbsenceId.VisibleIndex = 0;
			// 
			// colStartDate
			// 
			this.colStartDate.FieldName = "StartDate";
			this.colStartDate.Name = "colStartDate";
			this.colStartDate.Visible = true;
			this.colStartDate.VisibleIndex = 5;
			// 
			// colNumOfAbsence
			// 
			this.colNumOfAbsence.FieldName = "NumOfAbsence";
			this.colNumOfAbsence.Name = "colNumOfAbsence";
			this.colNumOfAbsence.Visible = true;
			this.colNumOfAbsence.VisibleIndex = 4;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.FieldName = "CreatedDate";
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.Visible = true;
			this.colCreatedDate.VisibleIndex = 6;
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 7;
			// 
			// colStudent
			// 
			this.colStudent.Caption = "Student Id";
			this.colStudent.FieldName = "Student.StudentId";
			this.colStudent.Name = "colStudent";
			this.colStudent.Visible = true;
			this.colStudent.VisibleIndex = 1;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Name";
			this.gridColumn1.FieldName = "Student.Name";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 3;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Room Id";
			this.gridColumn2.FieldName = "Student.RoomId";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 2;
			// 
			// FormTemporaryAbsence
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 518);
			this.Controls.Add(this.gridControl1);
			this.Name = "FormTemporaryAbsence";
			this.Text = "FormTemporaryAbsence";
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.temporaryAbsenceDtoBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.BindingSource temporaryAbsenceDtoBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colAbsenceId;
		private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
		private DevExpress.XtraGrid.Columns.GridColumn colNumOfAbsence;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colStudent;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
	}
}