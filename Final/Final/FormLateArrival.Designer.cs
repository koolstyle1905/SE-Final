namespace Final
{
	partial class FormLateArrival
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
			this.lateArrivalDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colLateId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWorkingAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colArrivalTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStudent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lateArrivalDtoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.lateArrivalDtoBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(562, 492);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLateId,
            this.colCreatedDate,
            this.colDescription,
            this.colStudent,
            this.gridColumn1,
            this.colWorkingAddress,
            this.colArrivalTime});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// lateArrivalDtoBindingSource
			// 
			this.lateArrivalDtoBindingSource.DataSource = typeof(DataTransfer.LateArrivalDto);
			// 
			// colLateId
			// 
			this.colLateId.FieldName = "LateId";
			this.colLateId.Name = "colLateId";
			this.colLateId.Visible = true;
			this.colLateId.VisibleIndex = 0;
			// 
			// colWorkingAddress
			// 
			this.colWorkingAddress.FieldName = "WorkingAddress";
			this.colWorkingAddress.Name = "colWorkingAddress";
			this.colWorkingAddress.Visible = true;
			this.colWorkingAddress.VisibleIndex = 3;
			// 
			// colArrivalTime
			// 
			this.colArrivalTime.FieldName = "ArrivalTime";
			this.colArrivalTime.Name = "colArrivalTime";
			this.colArrivalTime.Visible = true;
			this.colArrivalTime.VisibleIndex = 4;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.FieldName = "CreatedDate";
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.Visible = true;
			this.colCreatedDate.VisibleIndex = 5;
			// 
			// colDescription
			// 
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 6;
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
			this.gridColumn1.VisibleIndex = 2;
			// 
			// FormLateArrival
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 492);
			this.Controls.Add(this.gridControl1);
			this.Name = "FormLateArrival";
			this.Text = "FormLateArrival";
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lateArrivalDtoBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.BindingSource lateArrivalDtoBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colLateId;
		private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colStudent;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn colWorkingAddress;
		private DevExpress.XtraGrid.Columns.GridColumn colArrivalTime;
	}
}