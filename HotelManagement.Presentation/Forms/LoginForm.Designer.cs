namespace HotelManagement.Presentation.Forms
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			panel1 = new Panel();
			btnMini = new FontAwesome.Sharp.IconPictureBox();
			btnClose = new FontAwesome.Sharp.IconPictureBox();
			btnHome = new PictureBox();
			lblEmail = new Label();
			label1 = new Label();
			txtEmail = new CustomControl.CustomTextBox();
			txtPassword = new CustomControl.CustomTextBox();
			linkLabel1 = new LinkLabel();
			customButton1 = new CustomControl.CustomButton();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)btnMini).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(14, 36, 66);
			panel1.Controls.Add(btnMini);
			panel1.Controls.Add(btnClose);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(332, 32);
			panel1.TabIndex = 0;
			panel1.MouseDown += panelTitleBar_MouseDown;
			// 
			// btnMini
			// 
			btnMini.BackColor = Color.FromArgb(14, 36, 66);
			btnMini.Dock = DockStyle.Right;
			btnMini.IconChar = FontAwesome.Sharp.IconChar.Subtract;
			btnMini.IconColor = Color.White;
			btnMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnMini.Location = new Point(258, 0);
			btnMini.Margin = new Padding(4, 3, 4, 3);
			btnMini.Name = "btnMini";
			btnMini.Size = new Size(37, 32);
			btnMini.TabIndex = 5;
			btnMini.TabStop = false;
			btnMini.Click += btnMini_Click;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.FromArgb(14, 36, 66);
			btnClose.Dock = DockStyle.Right;
			btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
			btnClose.IconColor = Color.White;
			btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnClose.Location = new Point(295, 0);
			btnClose.Margin = new Padding(4, 3, 4, 3);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(37, 32);
			btnClose.TabIndex = 3;
			btnClose.TabStop = false;
			btnClose.Click += btnClose_Click;
			// 
			// btnHome
			// 
			btnHome.Dock = DockStyle.Top;
			btnHome.Image = (Image)resources.GetObject("btnHome.Image");
			btnHome.Location = new Point(0, 32);
			btnHome.Margin = new Padding(4, 3, 4, 3);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(332, 173);
			btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
			btnHome.TabIndex = 1;
			btnHome.TabStop = false;
			btnHome.MouseDown += panelTitleBar_MouseDown;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			lblEmail.ForeColor = Color.FromArgb(78, 205, 196);
			lblEmail.Location = new Point(39, 258);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(55, 18);
			lblEmail.TabIndex = 2;
			lblEmail.Text = "Email ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(78, 205, 196);
			label1.Location = new Point(39, 348);
			label1.Name = "label1";
			label1.Size = new Size(87, 18);
			label1.TabIndex = 4;
			label1.Text = "Password";
			// 
			// txtEmail
			// 
			txtEmail.BackColor = SystemColors.Window;
			txtEmail.BackgroundColor = SystemColors.Window;
			txtEmail.BorderColor = Color.FromArgb(78, 205, 196);
			txtEmail.BorderFocusColor = Color.FromArgb(255, 185, 70);
			txtEmail.BorderRadius = 15;
			txtEmail.BorderSize = 2;
			txtEmail.Font = new Font("Segoe UI", 9.5F);
			txtEmail.ForeColor = SystemColors.GradientActiveCaption;
			txtEmail.Location = new Point(39, 280);
			txtEmail.Margin = new Padding(4);
			txtEmail.Name = "txtEmail";
			txtEmail.Padding = new Padding(7);
			txtEmail.PassWordChar1 = false;
			txtEmail.Size = new Size(256, 32);
			txtEmail.TabIndex = 5;
			txtEmail.TextColor = SystemColors.WindowText;
			txtEmail.TextString = "";
			txtEmail.UnderlinedStyle = false;
			// 
			// txtPassword
			// 
			txtPassword.BackColor = SystemColors.Window;
			txtPassword.BackgroundColor = SystemColors.Window;
			txtPassword.BorderColor = Color.FromArgb(78, 205, 196);
			txtPassword.BorderFocusColor = Color.FromArgb(255, 185, 70);
			txtPassword.BorderRadius = 15;
			txtPassword.BorderSize = 2;
			txtPassword.Font = new Font("Segoe UI", 9.5F);
			txtPassword.ForeColor = SystemColors.GradientActiveCaption;
			txtPassword.Location = new Point(39, 370);
			txtPassword.Margin = new Padding(4);
			txtPassword.Name = "txtPassword";
			txtPassword.Padding = new Padding(7);
			txtPassword.PassWordChar1 = true;
			txtPassword.Size = new Size(256, 32);
			txtPassword.TabIndex = 6;
			txtPassword.TextColor = SystemColors.WindowText;
			txtPassword.TextString = "";
			txtPassword.UnderlinedStyle = false;
			// 
			// linkLabel1
			// 
			linkLabel1.ActiveLinkColor = Color.FromArgb(255, 185, 70);
			linkLabel1.AutoSize = true;
			linkLabel1.LinkColor = Color.PaleTurquoise;
			linkLabel1.Location = new Point(118, 419);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(89, 15);
			linkLabel1.TabIndex = 9;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Quên mật khẩu";
			// 
			// customButton1
			// 
			customButton1.BackColor = Color.FromArgb(78, 205, 196);
			customButton1.BackgroundColor = Color.FromArgb(78, 205, 196);
			customButton1.BorderColor = Color.PaleVioletRed;
			customButton1.BorderRadius = 40;
			customButton1.BorderSize = 0;
			customButton1.FlatAppearance.BorderSize = 0;
			customButton1.FlatStyle = FlatStyle.Flat;
			customButton1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
			customButton1.ForeColor = Color.FromArgb(224, 230, 237);
			customButton1.Location = new Point(91, 494);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(150, 40);
			customButton1.TabIndex = 10;
			customButton1.Text = "Đăng Nhập";
			customButton1.TextColor = Color.FromArgb(224, 230, 237);
			customButton1.TextString = "Đăng Nhập";
			customButton1.UseVisualStyleBackColor = false;
			customButton1.Click += customButton1_Click;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(14, 36, 66);
			ClientSize = new Size(332, 603);
			Controls.Add(customButton1);
			Controls.Add(linkLabel1);
			Controls.Add(txtPassword);
			Controls.Add(txtEmail);
			Controls.Add(label1);
			Controls.Add(lblEmail);
			Controls.Add(btnHome);
			Controls.Add(panel1);
			DoubleBuffered = true;
			ForeColor = Color.Transparent;
			FormBorderStyle = FormBorderStyle.None;
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LoginForm";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)btnMini).EndInit();
			((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
			((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private FontAwesome.Sharp.IconPictureBox btnClose;
		private FontAwesome.Sharp.IconPictureBox btnMini;
		private PictureBox btnHome;
		private Label lblEmail;
		private Label label1;
		private CustomControl.CustomTextBox txtEmail;
		private CustomControl.CustomTextBox txtPassword;
		private LinkLabel linkLabel1;
		private CustomControl.CustomButton customButton1;
	}
}