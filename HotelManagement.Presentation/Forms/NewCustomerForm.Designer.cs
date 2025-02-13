namespace HotelManagement.Presentation.Forms
{
	partial class NewCustomerForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnCancel;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			lblTitle = new Label();
			lblUsername = new Label();
			txtFirstName = new TextBox();
			txtPhone = new TextBox();
			btnRegister = new Button();
			btnCancel = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtLastName = new TextBox();
			txtEmail = new TextBox();
			SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.White;
			lblTitle.Location = new Point(94, 16);
			lblTitle.Margin = new Padding(4, 0, 4, 0);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(308, 24);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Tạo Tài Khoản Khách Hàng Mới";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Segoe UI", 12F);
			lblUsername.ForeColor = Color.White;
			lblUsername.Location = new Point(58, 79);
			lblUsername.Margin = new Padding(4, 0, 4, 0);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(120, 21);
			lblUsername.TabIndex = 1;
			lblUsername.Text = "Tên Khách Hàng";
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(210, 81);
			txtFirstName.Margin = new Padding(4, 3, 4, 3);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(233, 23);
			txtFirstName.TabIndex = 2;
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(210, 219);
			txtPhone.Margin = new Padding(4, 3, 4, 3);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(233, 23);
			txtPhone.TabIndex = 8;
			// 
			// btnRegister
			// 
			btnRegister.Location = new Point(210, 277);
			btnRegister.Margin = new Padding(4, 3, 4, 3);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(105, 35);
			btnRegister.TabIndex = 9;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(338, 277);
			btnCancel.Margin = new Padding(4, 3, 4, 3);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(105, 35);
			btnCancel.TabIndex = 10;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.ForeColor = Color.White;
			label1.Location = new Point(58, 127);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(115, 21);
			label1.TabIndex = 11;
			label1.Text = "Họ Và Tên Đệm";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.ForeColor = Color.White;
			label2.Location = new Point(58, 173);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(48, 21);
			label2.TabIndex = 12;
			label2.Text = "Email";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.ForeColor = Color.White;
			label3.Location = new Point(58, 219);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(106, 21);
			label3.TabIndex = 13;
			label3.Text = "Số Điện Thoại";
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(210, 127);
			txtLastName.Margin = new Padding(4, 3, 4, 3);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(233, 23);
			txtLastName.TabIndex = 14;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(210, 173);
			txtEmail.Margin = new Padding(4, 3, 4, 3);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(233, 23);
			txtEmail.TabIndex = 15;
			// 
			// AddCustomerControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(12, 42, 92);
			Controls.Add(txtEmail);
			Controls.Add(txtLastName);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lblTitle);
			Controls.Add(lblUsername);
			Controls.Add(txtFirstName);
			Controls.Add(txtPhone);
			Controls.Add(btnRegister);
			Controls.Add(btnCancel);
			Margin = new Padding(4, 3, 4, 3);
			Name = "AddCustomerControl";
			Size = new Size(506, 359);
			ResumeLayout(false);
			PerformLayout();
		}

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtLastName;
		private TextBox txtEmail;
	}
}