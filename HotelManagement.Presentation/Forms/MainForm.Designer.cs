﻿namespace HotelManagement.Presentation
{
	partial class MainForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			panelMenu = new Panel();
			txtName = new Label();
			btnLogOut = new FontAwesome.Sharp.IconPictureBox();
			btnHoaDon = new FontAwesome.Sharp.IconButton();
			btnDichVu = new FontAwesome.Sharp.IconButton();
			btnPhong = new FontAwesome.Sharp.IconButton();
			btnKhachHang = new FontAwesome.Sharp.IconButton();
			btnTrangChu = new FontAwesome.Sharp.IconButton();
			panelLogo = new Panel();
			btnHome = new PictureBox();
			panelShadow1 = new Panel();
			panelTitleBar = new Panel();
			btnMini = new FontAwesome.Sharp.IconPictureBox();
			btnSize = new FontAwesome.Sharp.IconPictureBox();
			btnClose = new FontAwesome.Sharp.IconPictureBox();
			lblTitleChildForm = new Label();
			iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			panelShadow2 = new Panel();
			panelDesktop = new Panel();
			taiKhoanBindingSource = new BindingSource(components);
			panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
			panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
			panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)btnMini).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnSize).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
			((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
			((System.ComponentModel.ISupportInitialize)taiKhoanBindingSource).BeginInit();
			SuspendLayout();
			// 
			// panelMenu
			// 
			panelMenu.BackColor = Color.FromArgb(14, 36, 66);
			panelMenu.Controls.Add(txtName);
			panelMenu.Controls.Add(btnLogOut);
			panelMenu.Controls.Add(btnHoaDon);
			panelMenu.Controls.Add(btnDichVu);
			panelMenu.Controls.Add(btnPhong);
			panelMenu.Controls.Add(btnKhachHang);
			panelMenu.Controls.Add(btnTrangChu);
			panelMenu.Controls.Add(panelLogo);
			panelMenu.Dock = DockStyle.Left;
			panelMenu.Location = new Point(0, 0);
			panelMenu.Margin = new Padding(4, 3, 4, 3);
			panelMenu.Name = "panelMenu";
			panelMenu.Size = new Size(257, 786);
			panelMenu.TabIndex = 0;
			// 
			// txtName
			// 
			txtName.AutoSize = true;
			txtName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
			txtName.ForeColor = Color.White;
			txtName.Location = new Point(58, 752);
			txtName.Margin = new Padding(4, 0, 4, 0);
			txtName.Name = "txtName";
			txtName.Size = new Size(46, 25);
			txtName.TabIndex = 8;
			txtName.Text = "Tên:";
			// 
			// btnLogOut
			// 
			btnLogOut.BackColor = Color.FromArgb(14, 36, 66);
			btnLogOut.ForeColor = Color.Red;
			btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
			btnLogOut.IconColor = Color.Red;
			btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnLogOut.IconSize = 50;
			btnLogOut.Location = new Point(0, 736);
			btnLogOut.Margin = new Padding(4, 3, 4, 3);
			btnLogOut.Name = "btnLogOut";
			btnLogOut.Size = new Size(50, 50);
			btnLogOut.TabIndex = 6;
			btnLogOut.TabStop = false;
			btnLogOut.Click += btnLogOut_Click;
			// 
			// btnHoaDon
			// 
			btnHoaDon.Dock = DockStyle.Top;
			btnHoaDon.FlatAppearance.BorderSize = 0;
			btnHoaDon.FlatStyle = FlatStyle.Flat;
			btnHoaDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			btnHoaDon.ForeColor = Color.White;
			btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
			btnHoaDon.IconColor = Color.White;
			btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnHoaDon.IconSize = 32;
			btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
			btnHoaDon.Location = new Point(0, 449);
			btnHoaDon.Margin = new Padding(4, 3, 4, 3);
			btnHoaDon.Name = "btnHoaDon";
			btnHoaDon.Padding = new Padding(12, 0, 12, 0);
			btnHoaDon.Size = new Size(257, 69);
			btnHoaDon.TabIndex = 5;
			btnHoaDon.Text = "Quản Lý Hóa Đơn";
			btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
			btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnHoaDon.UseVisualStyleBackColor = true;
			btnHoaDon.Click += btnHoaDon_Click;
			// 
			// btnDichVu
			// 
			btnDichVu.Dock = DockStyle.Top;
			btnDichVu.FlatAppearance.BorderSize = 0;
			btnDichVu.FlatStyle = FlatStyle.Flat;
			btnDichVu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			btnDichVu.ForeColor = Color.White;
			btnDichVu.IconChar = FontAwesome.Sharp.IconChar.EnvelopesBulk;
			btnDichVu.IconColor = Color.White;
			btnDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnDichVu.IconSize = 32;
			btnDichVu.ImageAlign = ContentAlignment.MiddleLeft;
			btnDichVu.Location = new Point(0, 380);
			btnDichVu.Margin = new Padding(4, 3, 4, 3);
			btnDichVu.Name = "btnDichVu";
			btnDichVu.Padding = new Padding(12, 0, 12, 0);
			btnDichVu.Size = new Size(257, 69);
			btnDichVu.TabIndex = 4;
			btnDichVu.Text = "Quản Lý Dịch Vụ";
			btnDichVu.TextAlign = ContentAlignment.MiddleLeft;
			btnDichVu.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnDichVu.UseVisualStyleBackColor = true;
			btnDichVu.Click += btnDichVu_Click;
			// 
			// btnPhong
			// 
			btnPhong.Dock = DockStyle.Top;
			btnPhong.FlatAppearance.BorderSize = 0;
			btnPhong.FlatStyle = FlatStyle.Flat;
			btnPhong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			btnPhong.ForeColor = Color.White;
			btnPhong.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
			btnPhong.IconColor = Color.White;
			btnPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnPhong.IconSize = 32;
			btnPhong.ImageAlign = ContentAlignment.MiddleLeft;
			btnPhong.Location = new Point(0, 311);
			btnPhong.Margin = new Padding(4, 3, 4, 3);
			btnPhong.Name = "btnPhong";
			btnPhong.Padding = new Padding(12, 0, 12, 0);
			btnPhong.Size = new Size(257, 69);
			btnPhong.TabIndex = 3;
			btnPhong.Text = "Quản Lý Nhân Viên";
			btnPhong.TextAlign = ContentAlignment.MiddleLeft;
			btnPhong.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnPhong.UseVisualStyleBackColor = true;
			btnPhong.Click += btnPhong_Click;
			// 
			// btnKhachHang
			// 
			btnKhachHang.Dock = DockStyle.Top;
			btnKhachHang.FlatAppearance.BorderSize = 0;
			btnKhachHang.FlatStyle = FlatStyle.Flat;
			btnKhachHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			btnKhachHang.ForeColor = Color.White;
			btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
			btnKhachHang.IconColor = Color.White;
			btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnKhachHang.IconSize = 32;
			btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
			btnKhachHang.Location = new Point(0, 242);
			btnKhachHang.Margin = new Padding(4, 3, 4, 3);
			btnKhachHang.Name = "btnKhachHang";
			btnKhachHang.Padding = new Padding(12, 0, 12, 0);
			btnKhachHang.Size = new Size(257, 69);
			btnKhachHang.TabIndex = 2;
			btnKhachHang.Text = "Quản Lý Khách Hàng";
			btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
			btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnKhachHang.UseVisualStyleBackColor = true;
			btnKhachHang.Click += btnKhachHang_Click;
			// 
			// btnTrangChu
			// 
			btnTrangChu.Dock = DockStyle.Top;
			btnTrangChu.FlatAppearance.BorderSize = 0;
			btnTrangChu.FlatStyle = FlatStyle.Flat;
			btnTrangChu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			btnTrangChu.ForeColor = Color.White;
			btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.House;
			btnTrangChu.IconColor = Color.White;
			btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnTrangChu.IconSize = 32;
			btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
			btnTrangChu.Location = new Point(0, 173);
			btnTrangChu.Margin = new Padding(4, 3, 4, 3);
			btnTrangChu.Name = "btnTrangChu";
			btnTrangChu.Padding = new Padding(12, 0, 12, 0);
			btnTrangChu.Size = new Size(257, 69);
			btnTrangChu.TabIndex = 1;
			btnTrangChu.Text = "Trang Chủ";
			btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
			btnTrangChu.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnTrangChu.UseVisualStyleBackColor = true;
			btnTrangChu.Click += btnTrangChu_Click;
			// 
			// panelLogo
			// 
			panelLogo.Controls.Add(btnHome);
			panelLogo.Dock = DockStyle.Top;
			panelLogo.Location = new Point(0, 0);
			panelLogo.Margin = new Padding(4, 3, 4, 3);
			panelLogo.Name = "panelLogo";
			panelLogo.Size = new Size(257, 173);
			panelLogo.TabIndex = 0;
			// 
			// btnHome
			// 
			btnHome.Dock = DockStyle.Fill;
			btnHome.Image = (Image)resources.GetObject("btnHome.Image");
			btnHome.Location = new Point(0, 0);
			btnHome.Margin = new Padding(4, 3, 4, 3);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(257, 173);
			btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
			btnHome.TabIndex = 0;
			btnHome.TabStop = false;
			btnHome.Click += btnHome_Click;
			btnHome.MouseDown += panelTitleBar_MouseDown;
			// 
			// panelShadow1
			// 
			panelShadow1.BackColor = Color.FromArgb(245, 247, 250);
			panelShadow1.Dock = DockStyle.Left;
			panelShadow1.Location = new Point(257, 0);
			panelShadow1.Margin = new Padding(4, 3, 4, 3);
			panelShadow1.Name = "panelShadow1";
			panelShadow1.Size = new Size(4, 786);
			panelShadow1.TabIndex = 1;
			// 
			// panelTitleBar
			// 
			panelTitleBar.BackColor = Color.FromArgb(12, 42, 92);
			panelTitleBar.Controls.Add(btnMini);
			panelTitleBar.Controls.Add(btnSize);
			panelTitleBar.Controls.Add(btnClose);
			panelTitleBar.Controls.Add(lblTitleChildForm);
			panelTitleBar.Controls.Add(iconCurrentChildForm);
			panelTitleBar.Dock = DockStyle.Top;
			panelTitleBar.Location = new Point(261, 0);
			panelTitleBar.Margin = new Padding(4, 3, 4, 3);
			panelTitleBar.Name = "panelTitleBar";
			panelTitleBar.Size = new Size(980, 37);
			panelTitleBar.TabIndex = 2;
			panelTitleBar.MouseDown += panelTitleBar_MouseDown;
			// 
			// btnMini
			// 
			btnMini.BackColor = Color.FromArgb(12, 42, 92);
			btnMini.Dock = DockStyle.Right;
			btnMini.IconChar = FontAwesome.Sharp.IconChar.Subtract;
			btnMini.IconColor = Color.White;
			btnMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnMini.IconSize = 37;
			btnMini.Location = new Point(869, 0);
			btnMini.Margin = new Padding(4, 3, 4, 3);
			btnMini.Name = "btnMini";
			btnMini.Size = new Size(37, 37);
			btnMini.TabIndex = 4;
			btnMini.TabStop = false;
			btnMini.Click += btnMini_Click;
			// 
			// btnSize
			// 
			btnSize.BackColor = Color.FromArgb(12, 42, 92);
			btnSize.Dock = DockStyle.Right;
			btnSize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
			btnSize.IconColor = Color.White;
			btnSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnSize.IconSize = 37;
			btnSize.Location = new Point(906, 0);
			btnSize.Margin = new Padding(4, 3, 4, 3);
			btnSize.Name = "btnSize";
			btnSize.Size = new Size(37, 37);
			btnSize.TabIndex = 3;
			btnSize.TabStop = false;
			btnSize.Click += btnSize_Click;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.FromArgb(12, 42, 92);
			btnClose.Dock = DockStyle.Right;
			btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
			btnClose.IconColor = Color.White;
			btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnClose.IconSize = 37;
			btnClose.Location = new Point(943, 0);
			btnClose.Margin = new Padding(4, 3, 4, 3);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(37, 37);
			btnClose.TabIndex = 2;
			btnClose.TabStop = false;
			btnClose.Click += btnClose_Click;
			// 
			// lblTitleChildForm
			// 
			lblTitleChildForm.AutoSize = true;
			lblTitleChildForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
			lblTitleChildForm.ForeColor = Color.White;
			lblTitleChildForm.Location = new Point(44, 5);
			lblTitleChildForm.Margin = new Padding(4, 0, 4, 0);
			lblTitleChildForm.Name = "lblTitleChildForm";
			lblTitleChildForm.Size = new Size(83, 21);
			lblTitleChildForm.TabIndex = 1;
			lblTitleChildForm.Text = "Trang Chủ";
			// 
			// iconCurrentChildForm
			// 
			iconCurrentChildForm.BackColor = Color.FromArgb(12, 42, 92);
			iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
			iconCurrentChildForm.IconColor = Color.White;
			iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconCurrentChildForm.IconSize = 37;
			iconCurrentChildForm.Location = new Point(0, 0);
			iconCurrentChildForm.Margin = new Padding(4, 3, 4, 3);
			iconCurrentChildForm.Name = "iconCurrentChildForm";
			iconCurrentChildForm.Size = new Size(37, 37);
			iconCurrentChildForm.TabIndex = 0;
			iconCurrentChildForm.TabStop = false;
			// 
			// panelShadow2
			// 
			panelShadow2.Dock = DockStyle.Top;
			panelShadow2.Location = new Point(261, 37);
			panelShadow2.Margin = new Padding(4, 3, 4, 3);
			panelShadow2.Name = "panelShadow2";
			panelShadow2.Size = new Size(980, 3);
			panelShadow2.TabIndex = 3;
			// 
			// panelDesktop
			// 
			panelDesktop.BackColor = Color.FromArgb(12, 42, 92);
			panelDesktop.Dock = DockStyle.Fill;
			panelDesktop.Location = new Point(261, 40);
			panelDesktop.Margin = new Padding(4, 3, 4, 3);
			panelDesktop.Name = "panelDesktop";
			panelDesktop.Size = new Size(980, 746);
			panelDesktop.TabIndex = 4;
			// 
			// taiKhoanBindingSource
			// 
			taiKhoanBindingSource.DataSource = typeof(Domain.Entities.TaiKhoan);
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1241, 786);
			Controls.Add(panelDesktop);
			Controls.Add(panelShadow2);
			Controls.Add(panelTitleBar);
			Controls.Add(panelShadow1);
			Controls.Add(panelMenu);
			Margin = new Padding(4, 3, 4, 3);
			Name = "MainForm";
			Text = "Form1";
			panelMenu.ResumeLayout(false);
			panelMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
			panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
			panelTitleBar.ResumeLayout(false);
			panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)btnMini).EndInit();
			((System.ComponentModel.ISupportInitialize)btnSize).EndInit();
			((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
			((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
			((System.ComponentModel.ISupportInitialize)taiKhoanBindingSource).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private FontAwesome.Sharp.IconButton btnTrangChu;
		private System.Windows.Forms.Panel panelLogo;
		private FontAwesome.Sharp.IconButton btnHoaDon;
		private FontAwesome.Sharp.IconButton btnDichVu;
		private FontAwesome.Sharp.IconButton btnPhong;
		private FontAwesome.Sharp.IconButton btnKhachHang;
		private System.Windows.Forms.PictureBox btnHome;
		private System.Windows.Forms.Panel panelShadow1;
		private System.Windows.Forms.Panel panelTitleBar;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.Label lblTitleChildForm;
		private System.Windows.Forms.Panel panelShadow2;
		private System.Windows.Forms.Panel panelDesktop;
		private FontAwesome.Sharp.IconPictureBox btnMini;
		private FontAwesome.Sharp.IconPictureBox btnSize;
		private FontAwesome.Sharp.IconPictureBox btnClose;
		private BindingSource taiKhoanBindingSource;
		private Label txtCurrentUser;
		private FontAwesome.Sharp.IconPictureBox btnLogOut;
		private Label txtName;
	}
}