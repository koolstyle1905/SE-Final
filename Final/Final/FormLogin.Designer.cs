namespace Final
{
	partial class FormLogin
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
			this.lblID = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(12, 15);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(77, 17);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "Username:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 48);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(73, 17);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(112, 12);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(253, 22);
			this.txtId.TabIndex = 2;
			this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(112, 45);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(253, 22);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(155, 88);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(102, 30);
			this.simpleButton1.TabIndex = 6;
			this.simpleButton1.Text = "Login";
			this.simpleButton1.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(263, 89);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(102, 30);
			this.simpleButton2.TabIndex = 7;
			this.simpleButton2.Text = "Configure";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 130);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblID);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLogin";
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtPassword;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}