namespace Final
{
	partial class FormContactUs
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContactUs));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelControl1.Location = new System.Drawing.Point(151, 121);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(249, 16);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "If you have any question about our product.";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelControl3.Location = new System.Drawing.Point(167, 143);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(207, 16);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Talk to us. We want your feed back.";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
			this.labelControl4.Location = new System.Drawing.Point(208, 187);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(121, 16);
			this.labelControl4.TabIndex = 3;
			this.labelControl4.Text = "Phone: 01223602166";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
			this.labelControl5.Location = new System.Drawing.Point(188, 165);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(160, 16);
			this.labelControl5.TabIndex = 4;
			this.labelControl5.Text = "Email: bao2703@gmail.com";
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.ZoomPercent = 50D;
			this.pictureEdit1.Size = new System.Drawing.Size(514, 103);
			this.pictureEdit1.TabIndex = 5;
			// 
			// FormContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 218);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormContact";
			this.Text = "FormContact";
			this.Load += new System.EventHandler(this.FormContact_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
	}
}