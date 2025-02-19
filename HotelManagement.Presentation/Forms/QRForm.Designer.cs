namespace HotelManagement.Presentation.Forms
{
	partial class QRForm
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			picLogo = new PictureBox();
			label6 = new Label();
			groupBox1 = new GroupBox();
			picQRMOMO = new PictureBox();
			groupBox2 = new GroupBox();
			txtNoiDung = new CustomControl.CustomTextBox();
			txtSoTien = new CustomControl.CustomTextBox();
			txtTenTaiKhoan = new CustomControl.CustomTextBox();
			txtSoTaiKhoan = new CustomControl.CustomTextBox();
			customButton2 = new CustomControl.CustomButton();
			customButton1 = new CustomControl.CustomButton();
			label7 = new Label();
			btnClose = new FontAwesome.Sharp.IconPictureBox();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picQRMOMO).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label1.ForeColor = Color.White;
			label1.Location = new Point(36, 40);
			label1.Name = "label1";
			label1.Size = new Size(91, 19);
			label1.TabIndex = 0;
			label1.Text = "Số tài khoản:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label2.ForeColor = Color.White;
			label2.Location = new Point(72, 119);
			label2.Name = "label2";
			label2.Size = new Size(55, 19);
			label2.TabIndex = 1;
			label2.Text = "Số tiền:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label3.ForeColor = Color.White;
			label3.Location = new Point(56, 159);
			label3.Name = "label3";
			label3.Size = new Size(71, 19);
			label3.TabIndex = 2;
			label3.Text = "Nội dung:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label4.ForeColor = Color.White;
			label4.Location = new Point(135, 195);
			label4.Name = "label4";
			label4.Size = new Size(152, 19);
			label4.TabIndex = 6;
			label4.Text = "(Tiếng việt không dấu)";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(72, 230);
			label5.Name = "label5";
			label5.Size = new Size(43, 19);
			label5.TabIndex = 7;
			label5.Text = "Logo:";
			// 
			// picLogo
			// 
			picLogo.BackColor = SystemColors.ButtonHighlight;
			picLogo.Location = new Point(135, 230);
			picLogo.Name = "picLogo";
			picLogo.Size = new Size(64, 64);
			picLogo.SizeMode = PictureBoxSizeMode.Zoom;
			picLogo.TabIndex = 8;
			picLogo.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.DeepPink;
			label6.Location = new Point(295, 9);
			label6.Name = "label6";
			label6.Size = new Size(354, 29);
			label6.TabIndex = 10;
			label6.Text = "TẠO MÃ QR MOMO ĐA NĂNG";
			label6.MouseDown += panelTitleBar_MouseDown;
			// 
			// groupBox1
			// 
			groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
			groupBox1.Controls.Add(picQRMOMO);
			groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			groupBox1.ForeColor = Color.White;
			groupBox1.Location = new Point(530, 70);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(345, 364);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			groupBox1.Text = "Mã QR Đa năng";
			// 
			// picQRMOMO
			// 
			picQRMOMO.Dock = DockStyle.Fill;
			picQRMOMO.Location = new Point(3, 21);
			picQRMOMO.Name = "picQRMOMO";
			picQRMOMO.Size = new Size(339, 340);
			picQRMOMO.SizeMode = PictureBoxSizeMode.Zoom;
			picQRMOMO.TabIndex = 0;
			picQRMOMO.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(txtNoiDung);
			groupBox2.Controls.Add(txtSoTien);
			groupBox2.Controls.Add(txtTenTaiKhoan);
			groupBox2.Controls.Add(txtSoTaiKhoan);
			groupBox2.Controls.Add(customButton2);
			groupBox2.Controls.Add(customButton1);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(picLogo);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label4);
			groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			groupBox2.ForeColor = Color.White;
			groupBox2.Location = new Point(12, 70);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(487, 364);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
			groupBox2.Text = "Nhập thông tin";
			// 
			// txtNoiDung
			// 
			txtNoiDung.BackColor = SystemColors.Window;
			txtNoiDung.BackgroundColor = SystemColors.Window;
			txtNoiDung.BorderColor = Color.FromArgb(74, 144, 226);
			txtNoiDung.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtNoiDung.BorderRadius = 10;
			txtNoiDung.BorderSize = 3;
			txtNoiDung.Font = new Font("Segoe UI", 9.5F);
			txtNoiDung.ForeColor = SystemColors.GradientActiveCaption;
			txtNoiDung.Location = new Point(134, 159);
			txtNoiDung.Margin = new Padding(4);
			txtNoiDung.Name = "txtNoiDung";
			txtNoiDung.Padding = new Padding(7);
			txtNoiDung.PassWordChar1 = false;
			txtNoiDung.Size = new Size(290, 32);
			txtNoiDung.TabIndex = 19;
			txtNoiDung.TextColor = SystemColors.WindowText;
			txtNoiDung.TextString = "";
			txtNoiDung.UnderlinedStyle = false;
			// 
			// txtSoTien
			// 
			txtSoTien.BackColor = SystemColors.Window;
			txtSoTien.BackgroundColor = SystemColors.Window;
			txtSoTien.BorderColor = Color.FromArgb(74, 144, 226);
			txtSoTien.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtSoTien.BorderRadius = 10;
			txtSoTien.BorderSize = 3;
			txtSoTien.Font = new Font("Segoe UI", 9.5F);
			txtSoTien.ForeColor = SystemColors.GradientActiveCaption;
			txtSoTien.Location = new Point(134, 119);
			txtSoTien.Margin = new Padding(4);
			txtSoTien.Name = "txtSoTien";
			txtSoTien.Padding = new Padding(7);
			txtSoTien.PassWordChar1 = false;
			txtSoTien.Size = new Size(290, 32);
			txtSoTien.TabIndex = 18;
			txtSoTien.TextColor = SystemColors.WindowText;
			txtSoTien.TextString = "";
			txtSoTien.UnderlinedStyle = false;
			// 
			// txtTenTaiKhoan
			// 
			txtTenTaiKhoan.BackColor = SystemColors.Window;
			txtTenTaiKhoan.BackgroundColor = SystemColors.Window;
			txtTenTaiKhoan.BorderColor = Color.FromArgb(74, 144, 226);
			txtTenTaiKhoan.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtTenTaiKhoan.BorderRadius = 10;
			txtTenTaiKhoan.BorderSize = 3;
			txtTenTaiKhoan.Font = new Font("Segoe UI", 9.5F);
			txtTenTaiKhoan.ForeColor = SystemColors.GradientActiveCaption;
			txtTenTaiKhoan.Location = new Point(135, 79);
			txtTenTaiKhoan.Margin = new Padding(4);
			txtTenTaiKhoan.Name = "txtTenTaiKhoan";
			txtTenTaiKhoan.Padding = new Padding(7);
			txtTenTaiKhoan.PassWordChar1 = false;
			txtTenTaiKhoan.Size = new Size(290, 32);
			txtTenTaiKhoan.TabIndex = 17;
			txtTenTaiKhoan.TextColor = SystemColors.WindowText;
			txtTenTaiKhoan.TextString = "LAI QUANG HAI";
			txtTenTaiKhoan.UnderlinedStyle = false;
			// 
			// txtSoTaiKhoan
			// 
			txtSoTaiKhoan.BackColor = SystemColors.Window;
			txtSoTaiKhoan.BackgroundColor = SystemColors.Window;
			txtSoTaiKhoan.BorderColor = Color.FromArgb(74, 144, 226);
			txtSoTaiKhoan.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtSoTaiKhoan.BorderRadius = 10;
			txtSoTaiKhoan.BorderSize = 3;
			txtSoTaiKhoan.Font = new Font("Segoe UI", 9.5F);
			txtSoTaiKhoan.ForeColor = SystemColors.GradientActiveCaption;
			txtSoTaiKhoan.Location = new Point(134, 39);
			txtSoTaiKhoan.Margin = new Padding(4);
			txtSoTaiKhoan.Name = "txtSoTaiKhoan";
			txtSoTaiKhoan.Padding = new Padding(7);
			txtSoTaiKhoan.PassWordChar1 = false;
			txtSoTaiKhoan.Size = new Size(290, 32);
			txtSoTaiKhoan.TabIndex = 16;
			txtSoTaiKhoan.TextColor = SystemColors.WindowText;
			txtSoTaiKhoan.TextString = "9021209469297";
			txtSoTaiKhoan.UnderlinedStyle = false;
			// 
			// customButton2
			// 
			customButton2.BackColor = Color.FromArgb(74, 144, 226);
			customButton2.BackgroundColor = Color.FromArgb(74, 144, 226);
			customButton2.BorderColor = Color.White;
			customButton2.BorderRadius = 40;
			customButton2.BorderSize = 4;
			customButton2.FlatAppearance.BorderSize = 0;
			customButton2.FlatStyle = FlatStyle.Flat;
			customButton2.ForeColor = Color.White;
			customButton2.Location = new Point(120, 309);
			customButton2.Name = "customButton2";
			customButton2.Size = new Size(93, 40);
			customButton2.TabIndex = 15;
			customButton2.Text = "Chọn Logo";
			customButton2.TextColor = Color.White;
			customButton2.TextString = "Chọn Logo";
			customButton2.UseVisualStyleBackColor = false;
			customButton2.Click += button1_Click;
			// 
			// customButton1
			// 
			customButton1.BackColor = Color.FromArgb(74, 144, 226);
			customButton1.BackgroundColor = Color.FromArgb(74, 144, 226);
			customButton1.BorderColor = Color.White;
			customButton1.BorderRadius = 50;
			customButton1.BorderSize = 4;
			customButton1.FlatAppearance.BorderSize = 0;
			customButton1.FlatStyle = FlatStyle.Flat;
			customButton1.ForeColor = Color.White;
			customButton1.Location = new Point(250, 243);
			customButton1.Name = "customButton1";
			customButton1.Size = new Size(161, 51);
			customButton1.TabIndex = 14;
			customButton1.Text = "Tạo Mã Thanh Toán";
			customButton1.TextColor = Color.White;
			customButton1.TextString = "Tạo Mã Thanh Toán";
			customButton1.UseVisualStyleBackColor = false;
			customButton1.Click += button2_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label7.ForeColor = Color.White;
			label7.Location = new Point(29, 79);
			label7.Name = "label7";
			label7.Size = new Size(99, 19);
			label7.TabIndex = 12;
			label7.Text = "Tên tài khoản:";
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.FromArgb(12, 42, 92);
			btnClose.Dock = DockStyle.Right;
			btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
			btnClose.IconColor = Color.White;
			btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnClose.IconSize = 37;
			btnClose.Location = new Point(912, 0);
			btnClose.Margin = new Padding(4, 3, 4, 3);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(37, 48);
			btnClose.TabIndex = 14;
			btnClose.TabStop = false;
			btnClose.Click += btnClose_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(label6);
			panel1.Controls.Add(btnClose);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(949, 48);
			panel1.TabIndex = 15;
			panel1.MouseDown += panelTitleBar_MouseDown;
			// 
			// QRForm
			// 
			AutoScaleDimensions = new SizeF(7F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(14, 36, 66);
			ClientSize = new Size(949, 458);
			Controls.Add(panel1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			Name = "QRForm";
			StartPosition = FormStartPosition.CenterScreen;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picQRMOMO).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox picQRMOMO;
		private System.Windows.Forms.Label label7;
		private CustomControl.CustomButton customButton2;
		private CustomControl.CustomButton customButton1;
		private CustomControl.CustomTextBox txtSoTaiKhoan;
		private CustomControl.CustomTextBox txtNoiDung;
		private CustomControl.CustomTextBox txtSoTien;
		private CustomControl.CustomTextBox txtTenTaiKhoan;
		private FontAwesome.Sharp.IconPictureBox btnClose;
		private Panel panel1;
	}
}