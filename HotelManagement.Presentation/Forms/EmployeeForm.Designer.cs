namespace HotelManagement.Presentation.Forms
{
	partial class EmployeeForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			panelTop = new TableLayoutPanel();
			btnSearch = new FontAwesome.Sharp.IconButton();
			txtSearchBox = new CustomControl.CustomTextBox();
			btnEdit = new FontAwesome.Sharp.IconButton();
			label1 = new Label();
			btnAdd = new FontAwesome.Sharp.IconButton();
			btnRefresh = new FontAwesome.Sharp.IconButton();
			btnDelete = new FontAwesome.Sharp.IconButton();
			panelSide = new Panel();
			tableLayoutPanel2 = new TableLayoutPanel();
			label2 = new Label();
			lblSidePanel = new Label();
			iconCustomer = new FontAwesome.Sharp.IconPictureBox();
			txtAddress = new CustomControl.CustomTextBox();
			txtPhone = new CustomControl.CustomTextBox();
			txtEmail = new CustomControl.CustomTextBox();
			txtLastName = new CustomControl.CustomTextBox();
			radioNu = new RadioButton();
			radioKhac = new RadioButton();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtFirstName = new CustomControl.CustomTextBox();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			radioNam = new RadioButton();
			cbRole = new ComboBox();
			panel3 = new Panel();
			btnCancel = new FontAwesome.Sharp.IconButton();
			btnAccept = new FontAwesome.Sharp.IconButton();
			panel2 = new Panel();
			panelShadow2 = new Panel();
			panelShadow = new Panel();
			panelGrid = new Panel();
			dataGridView1 = new DataGridView();
			panelTop.SuspendLayout();
			panelSide.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)iconCustomer).BeginInit();
			panel3.SuspendLayout();
			panelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.BackColor = Color.FromArgb(14, 36, 66);
			panelTop.ColumnCount = 7;
			panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			panelTop.Controls.Add(btnSearch, 2, 0);
			panelTop.Controls.Add(txtSearchBox, 1, 0);
			panelTop.Controls.Add(btnEdit, 5, 0);
			panelTop.Controls.Add(label1, 0, 0);
			panelTop.Controls.Add(btnAdd, 4, 0);
			panelTop.Controls.Add(btnRefresh, 3, 0);
			panelTop.Controls.Add(btnDelete, 6, 0);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(2);
			panelTop.RowCount = 1;
			panelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			panelTop.Size = new Size(800, 60);
			panelTop.TabIndex = 0;
			// 
			// btnSearch
			// 
			btnSearch.BackColor = Color.FromArgb(74, 144, 226);
			btnSearch.Dock = DockStyle.Fill;
			btnSearch.FlatStyle = FlatStyle.Flat;
			btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnSearch.ForeColor = Color.White;
			btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			btnSearch.IconColor = Color.White;
			btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnSearch.IconSize = 25;
			btnSearch.Location = new Point(402, 5);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(73, 50);
			btnSearch.TabIndex = 3;
			btnSearch.Text = "TìmKiếm";
			btnSearch.TextImageRelation = TextImageRelation.ImageAboveText;
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			// 
			// txtSearchBox
			// 
			txtSearchBox.BackColor = SystemColors.Window;
			txtSearchBox.BackgroundColor = SystemColors.Window;
			txtSearchBox.BorderColor = Color.FromArgb(74, 144, 226);
			txtSearchBox.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtSearchBox.BorderRadius = 10;
			txtSearchBox.BorderSize = 2;
			txtSearchBox.Font = new Font("Segoe UI", 9.5F);
			txtSearchBox.ForeColor = SystemColors.GradientActiveCaption;
			txtSearchBox.Location = new Point(165, 6);
			txtSearchBox.Margin = new Padding(4);
			txtSearchBox.Name = "txtSearchBox";
			txtSearchBox.Padding = new Padding(7);
			txtSearchBox.PassWordChar1 = false;
			txtSearchBox.Size = new Size(230, 32);
			txtSearchBox.TabIndex = 6;
			txtSearchBox.TextColor = SystemColors.WindowText;
			txtSearchBox.TextString = "";
			txtSearchBox.UnderlinedStyle = false;
			// 
			// btnEdit
			// 
			btnEdit.BackColor = Color.FromArgb(74, 144, 226);
			btnEdit.Dock = DockStyle.Fill;
			btnEdit.FlatStyle = FlatStyle.Flat;
			btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnEdit.ForeColor = Color.White;
			btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
			btnEdit.IconColor = Color.White;
			btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnEdit.IconSize = 25;
			btnEdit.Location = new Point(639, 5);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(73, 50);
			btnEdit.TabIndex = 4;
			btnEdit.Text = "Sửa";
			btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
			btnEdit.UseVisualStyleBackColor = false;
			btnEdit.Click += btnEdit_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(74, 144, 226);
			label1.Location = new Point(5, 2);
			label1.Name = "label1";
			label1.Size = new Size(153, 56);
			label1.TabIndex = 1;
			label1.Text = "Tìm nhân viên :";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(74, 144, 226);
			btnAdd.Dock = DockStyle.Fill;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAdd.ForeColor = Color.White;
			btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
			btnAdd.IconColor = Color.White;
			btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnAdd.IconSize = 25;
			btnAdd.Location = new Point(560, 5);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(73, 50);
			btnAdd.TabIndex = 3;
			btnAdd.Text = "Thêm";
			btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.BackColor = Color.FromArgb(74, 144, 226);
			btnRefresh.Dock = DockStyle.Fill;
			btnRefresh.FlatStyle = FlatStyle.Flat;
			btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnRefresh.ForeColor = Color.White;
			btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
			btnRefresh.IconColor = Color.White;
			btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnRefresh.IconSize = 25;
			btnRefresh.Location = new Point(481, 5);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(73, 50);
			btnRefresh.TabIndex = 2;
			btnRefresh.Text = "LàmMới";
			btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
			btnRefresh.UseVisualStyleBackColor = false;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(74, 144, 226);
			btnDelete.Dock = DockStyle.Fill;
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDelete.ForeColor = Color.White;
			btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
			btnDelete.IconColor = Color.White;
			btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnDelete.IconSize = 25;
			btnDelete.Location = new Point(718, 5);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(77, 50);
			btnDelete.TabIndex = 0;
			btnDelete.Text = "Xóa";
			btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// panelSide
			// 
			panelSide.BackColor = Color.FromArgb(12, 42, 92);
			panelSide.Controls.Add(tableLayoutPanel2);
			panelSide.Controls.Add(panel3);
			panelSide.Controls.Add(panel2);
			panelSide.Controls.Add(panelShadow2);
			panelSide.Controls.Add(panelShadow);
			panelSide.Dock = DockStyle.Right;
			panelSide.Location = new Point(500, 60);
			panelSide.Name = "panelSide";
			panelSide.Size = new Size(300, 540);
			panelSide.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.Controls.Add(label2, 0, 13);
			tableLayoutPanel2.Controls.Add(lblSidePanel, 1, 0);
			tableLayoutPanel2.Controls.Add(iconCustomer, 0, 0);
			tableLayoutPanel2.Controls.Add(txtAddress, 0, 12);
			tableLayoutPanel2.Controls.Add(txtPhone, 0, 10);
			tableLayoutPanel2.Controls.Add(txtEmail, 0, 8);
			tableLayoutPanel2.Controls.Add(txtLastName, 0, 5);
			tableLayoutPanel2.Controls.Add(radioNu, 2, 6);
			tableLayoutPanel2.Controls.Add(radioKhac, 3, 6);
			tableLayoutPanel2.Controls.Add(label3, 0, 2);
			tableLayoutPanel2.Controls.Add(label4, 0, 4);
			tableLayoutPanel2.Controls.Add(label5, 0, 6);
			tableLayoutPanel2.Controls.Add(txtFirstName, 0, 3);
			tableLayoutPanel2.Controls.Add(label6, 0, 7);
			tableLayoutPanel2.Controls.Add(label7, 0, 9);
			tableLayoutPanel2.Controls.Add(label8, 0, 11);
			tableLayoutPanel2.Controls.Add(radioNam, 1, 6);
			tableLayoutPanel2.Controls.Add(cbRole, 0, 14);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(5, 5);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 16;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
			tableLayoutPanel2.Size = new Size(295, 480);
			tableLayoutPanel2.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(label2, 4);
			label2.Dock = DockStyle.Bottom;
			label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label2.ForeColor = Color.White;
			label2.Location = new Point(3, 401);
			label2.Name = "label2";
			label2.Size = new Size(289, 19);
			label2.TabIndex = 35;
			label2.Text = "Công việc:";
			// 
			// lblSidePanel
			// 
			lblSidePanel.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(lblSidePanel, 3);
			lblSidePanel.Dock = DockStyle.Fill;
			lblSidePanel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			lblSidePanel.ForeColor = Color.White;
			lblSidePanel.Location = new Point(76, 0);
			lblSidePanel.Name = "lblSidePanel";
			tableLayoutPanel2.SetRowSpan(lblSidePanel, 2);
			lblSidePanel.Size = new Size(216, 60);
			lblSidePanel.TabIndex = 4;
			lblSidePanel.Text = "Thông Tin Nhân Viên";
			lblSidePanel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// iconCustomer
			// 
			iconCustomer.BackColor = Color.FromArgb(12, 42, 92);
			iconCustomer.Dock = DockStyle.Fill;
			iconCustomer.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
			iconCustomer.IconColor = Color.White;
			iconCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconCustomer.IconSize = 54;
			iconCustomer.Location = new Point(3, 3);
			iconCustomer.Name = "iconCustomer";
			tableLayoutPanel2.SetRowSpan(iconCustomer, 2);
			iconCustomer.Size = new Size(67, 54);
			iconCustomer.TabIndex = 34;
			iconCustomer.TabStop = false;
			// 
			// txtAddress
			// 
			txtAddress.BackColor = SystemColors.Window;
			txtAddress.BackgroundColor = SystemColors.Window;
			txtAddress.BorderColor = Color.FromArgb(74, 144, 226);
			txtAddress.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtAddress.BorderRadius = 10;
			txtAddress.BorderSize = 2;
			tableLayoutPanel2.SetColumnSpan(txtAddress, 4);
			txtAddress.Dock = DockStyle.Fill;
			txtAddress.Font = new Font("Segoe UI", 9.5F);
			txtAddress.ForeColor = SystemColors.GradientActiveCaption;
			txtAddress.Location = new Point(4, 364);
			txtAddress.Margin = new Padding(4);
			txtAddress.Name = "txtAddress";
			txtAddress.Padding = new Padding(7);
			txtAddress.PassWordChar1 = false;
			txtAddress.Size = new Size(287, 32);
			txtAddress.TabIndex = 33;
			txtAddress.TextColor = SystemColors.WindowText;
			txtAddress.TextString = "";
			txtAddress.UnderlinedStyle = false;
			// 
			// txtPhone
			// 
			txtPhone.BackColor = SystemColors.Window;
			txtPhone.BackgroundColor = SystemColors.Window;
			txtPhone.BorderColor = Color.FromArgb(74, 144, 226);
			txtPhone.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtPhone.BorderRadius = 10;
			txtPhone.BorderSize = 2;
			tableLayoutPanel2.SetColumnSpan(txtPhone, 4);
			txtPhone.Dock = DockStyle.Fill;
			txtPhone.Font = new Font("Segoe UI", 9.5F);
			txtPhone.ForeColor = SystemColors.GradientActiveCaption;
			txtPhone.Location = new Point(4, 304);
			txtPhone.Margin = new Padding(4);
			txtPhone.Name = "txtPhone";
			txtPhone.Padding = new Padding(7);
			txtPhone.PassWordChar1 = false;
			txtPhone.Size = new Size(287, 32);
			txtPhone.TabIndex = 32;
			txtPhone.TextColor = SystemColors.WindowText;
			txtPhone.TextString = "";
			txtPhone.UnderlinedStyle = false;
			// 
			// txtEmail
			// 
			txtEmail.BackColor = SystemColors.Window;
			txtEmail.BackgroundColor = SystemColors.Window;
			txtEmail.BorderColor = Color.FromArgb(74, 144, 226);
			txtEmail.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtEmail.BorderRadius = 10;
			txtEmail.BorderSize = 2;
			tableLayoutPanel2.SetColumnSpan(txtEmail, 4);
			txtEmail.Dock = DockStyle.Fill;
			txtEmail.Font = new Font("Segoe UI", 9.5F);
			txtEmail.ForeColor = SystemColors.GradientActiveCaption;
			txtEmail.Location = new Point(4, 244);
			txtEmail.Margin = new Padding(4);
			txtEmail.Name = "txtEmail";
			txtEmail.Padding = new Padding(7);
			txtEmail.PassWordChar1 = false;
			txtEmail.Size = new Size(287, 32);
			txtEmail.TabIndex = 31;
			txtEmail.TextColor = SystemColors.WindowText;
			txtEmail.TextString = "";
			txtEmail.UnderlinedStyle = false;
			// 
			// txtLastName
			// 
			txtLastName.BackColor = SystemColors.Window;
			txtLastName.BackgroundColor = SystemColors.Window;
			txtLastName.BorderColor = Color.FromArgb(74, 144, 226);
			txtLastName.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtLastName.BorderRadius = 10;
			txtLastName.BorderSize = 2;
			tableLayoutPanel2.SetColumnSpan(txtLastName, 4);
			txtLastName.Dock = DockStyle.Fill;
			txtLastName.Font = new Font("Segoe UI", 9.5F);
			txtLastName.ForeColor = SystemColors.GradientActiveCaption;
			txtLastName.Location = new Point(4, 154);
			txtLastName.Margin = new Padding(4);
			txtLastName.Name = "txtLastName";
			txtLastName.Padding = new Padding(7);
			txtLastName.PassWordChar1 = false;
			txtLastName.Size = new Size(287, 32);
			txtLastName.TabIndex = 30;
			txtLastName.TextColor = SystemColors.WindowText;
			txtLastName.TextString = "";
			txtLastName.UnderlinedStyle = false;
			// 
			// radioNu
			// 
			radioNu.AutoSize = true;
			radioNu.Dock = DockStyle.Bottom;
			radioNu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			radioNu.ForeColor = Color.White;
			radioNu.Location = new Point(149, 186);
			radioNu.Name = "radioNu";
			radioNu.Size = new Size(67, 21);
			radioNu.TabIndex = 29;
			radioNu.Text = "Nữ";
			radioNu.UseVisualStyleBackColor = true;
			// 
			// radioKhac
			// 
			radioKhac.AutoSize = true;
			radioKhac.Checked = true;
			radioKhac.Dock = DockStyle.Bottom;
			radioKhac.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			radioKhac.ForeColor = Color.White;
			radioKhac.Location = new Point(222, 186);
			radioKhac.Name = "radioKhac";
			radioKhac.Size = new Size(70, 21);
			radioKhac.TabIndex = 28;
			radioKhac.TabStop = true;
			radioKhac.Text = "Khác";
			radioKhac.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(label3, 2);
			label3.Dock = DockStyle.Bottom;
			label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label3.ForeColor = Color.White;
			label3.Location = new Point(3, 71);
			label3.Name = "label3";
			label3.Size = new Size(140, 19);
			label3.TabIndex = 1;
			label3.Text = "Tên nhân viên :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(label4, 4);
			label4.Dock = DockStyle.Bottom;
			label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label4.ForeColor = Color.White;
			label4.Location = new Point(3, 131);
			label4.Name = "label4";
			label4.Size = new Size(289, 19);
			label4.TabIndex = 3;
			label4.Text = "Họ và tên đệm :";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Bottom;
			label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label5.ForeColor = Color.White;
			label5.Location = new Point(3, 191);
			label5.Name = "label5";
			label5.Size = new Size(67, 19);
			label5.TabIndex = 16;
			label5.Text = "Giới tính:";
			// 
			// txtFirstName
			// 
			txtFirstName.BackColor = SystemColors.Window;
			txtFirstName.BackgroundColor = SystemColors.Window;
			txtFirstName.BorderColor = Color.FromArgb(74, 144, 226);
			txtFirstName.BorderFocusColor = Color.FromArgb(78, 205, 196);
			txtFirstName.BorderRadius = 10;
			txtFirstName.BorderSize = 2;
			tableLayoutPanel2.SetColumnSpan(txtFirstName, 4);
			txtFirstName.Dock = DockStyle.Fill;
			txtFirstName.Font = new Font("Segoe UI", 9.5F);
			txtFirstName.ForeColor = SystemColors.GradientActiveCaption;
			txtFirstName.Location = new Point(4, 94);
			txtFirstName.Margin = new Padding(4);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Padding = new Padding(7);
			txtFirstName.PassWordChar1 = false;
			txtFirstName.Size = new Size(287, 32);
			txtFirstName.TabIndex = 17;
			txtFirstName.TextColor = SystemColors.WindowText;
			txtFirstName.TextString = "";
			txtFirstName.UnderlinedStyle = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(label6, 4);
			label6.Dock = DockStyle.Bottom;
			label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label6.ForeColor = Color.White;
			label6.Location = new Point(3, 221);
			label6.Name = "label6";
			label6.Size = new Size(289, 19);
			label6.TabIndex = 20;
			label6.Text = "Email :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(label7, 4);
			label7.Dock = DockStyle.Bottom;
			label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label7.ForeColor = Color.White;
			label7.Location = new Point(3, 281);
			label7.Name = "label7";
			label7.Size = new Size(289, 19);
			label7.TabIndex = 21;
			label7.Text = "Số điện thoại :";
			// 
			// label8
			// 
			label8.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(label8, 4);
			label8.Dock = DockStyle.Bottom;
			label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
			label8.ForeColor = Color.White;
			label8.Location = new Point(3, 341);
			label8.Name = "label8";
			label8.Size = new Size(289, 19);
			label8.TabIndex = 22;
			label8.Text = "Địa chỉ :";
			// 
			// radioNam
			// 
			radioNam.AutoSize = true;
			radioNam.Dock = DockStyle.Bottom;
			radioNam.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			radioNam.ForeColor = Color.White;
			radioNam.Location = new Point(76, 186);
			radioNam.Name = "radioNam";
			radioNam.Size = new Size(67, 21);
			radioNam.TabIndex = 27;
			radioNam.Text = "Nam";
			radioNam.UseVisualStyleBackColor = true;
			// 
			// cbRole
			// 
			tableLayoutPanel2.SetColumnSpan(cbRole, 2);
			cbRole.Dock = DockStyle.Fill;
			cbRole.FormattingEnabled = true;
			cbRole.Location = new Point(3, 423);
			cbRole.Name = "cbRole";
			cbRole.Size = new Size(140, 23);
			cbRole.TabIndex = 36;
			// 
			// panel3
			// 
			panel3.Controls.Add(btnCancel);
			panel3.Controls.Add(btnAccept);
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(5, 485);
			panel3.Name = "panel3";
			panel3.Size = new Size(295, 50);
			panel3.TabIndex = 3;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(74, 144, 226);
			btnCancel.Dock = DockStyle.Left;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCancel.ForeColor = Color.Red;
			btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
			btnCancel.IconColor = Color.Red;
			btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnCancel.IconSize = 25;
			btnCancel.Location = new Point(0, 0);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(76, 50);
			btnCancel.TabIndex = 2;
			btnCancel.Text = "Hủy Bỏ";
			btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnAccept
			// 
			btnAccept.BackColor = Color.FromArgb(74, 144, 226);
			btnAccept.Dock = DockStyle.Right;
			btnAccept.FlatStyle = FlatStyle.Flat;
			btnAccept.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnAccept.ForeColor = Color.Lime;
			btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
			btnAccept.IconColor = Color.Lime;
			btnAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnAccept.IconSize = 25;
			btnAccept.Location = new Point(219, 0);
			btnAccept.Name = "btnAccept";
			btnAccept.Size = new Size(76, 50);
			btnAccept.TabIndex = 1;
			btnAccept.Text = "Hoàn Tất";
			btnAccept.TextImageRelation = TextImageRelation.ImageAboveText;
			btnAccept.UseVisualStyleBackColor = false;
			btnAccept.Click += btnAccept_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(74, 144, 226);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(5, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(295, 5);
			panel2.TabIndex = 2;
			// 
			// panelShadow2
			// 
			panelShadow2.BackColor = Color.FromArgb(74, 144, 226);
			panelShadow2.Dock = DockStyle.Left;
			panelShadow2.Location = new Point(0, 0);
			panelShadow2.Name = "panelShadow2";
			panelShadow2.Size = new Size(5, 535);
			panelShadow2.TabIndex = 1;
			// 
			// panelShadow
			// 
			panelShadow.BackColor = Color.FromArgb(74, 144, 226);
			panelShadow.Dock = DockStyle.Bottom;
			panelShadow.Location = new Point(0, 535);
			panelShadow.Name = "panelShadow";
			panelShadow.Size = new Size(300, 5);
			panelShadow.TabIndex = 0;
			// 
			// panelGrid
			// 
			panelGrid.Controls.Add(dataGridView1);
			panelGrid.Dock = DockStyle.Fill;
			panelGrid.Location = new Point(0, 60);
			panelGrid.Name = "panelGrid";
			panelGrid.Size = new Size(500, 540);
			panelGrid.TabIndex = 2;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.BackgroundColor = Color.FromArgb(14, 36, 66);
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 36, 66);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.FromArgb(74, 144, 226);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(14, 36, 66);
			dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(74, 144, 226);
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 50;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.GridColor = Color.FromArgb(74, 144, 226);
			dataGridView1.Location = new Point(0, 0);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 36, 66);
			dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView1.RowHeadersWidth = 40;
			dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(14, 36, 66);
			dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
			dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
			dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(14, 36, 66);
			dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(500, 540);
			dataGridView1.TabIndex = 0;
			// 
			// EmployeeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 600);
			Controls.Add(panelGrid);
			Controls.Add(panelSide);
			Controls.Add(panelTop);
			FormBorderStyle = FormBorderStyle.None;
			Name = "EmployeeForm";
			Text = "RoleForm";
			panelTop.ResumeLayout(false);
			panelTop.PerformLayout();
			panelSide.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)iconCustomer).EndInit();
			panel3.ResumeLayout(false);
			panelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel panelTop;
		private FontAwesome.Sharp.IconButton btnDelete;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnAdd;
		private FontAwesome.Sharp.IconButton btnRefresh;
		private Label label1;
		private Panel panelSide;
		private Panel panelShadow;
		private Panel panelShadow2;
		private Panel panel2;
		private Panel panel3;
		private FontAwesome.Sharp.IconButton btnCancel;
		private FontAwesome.Sharp.IconButton btnAccept;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label3;
		private Label label4;
		private Label label5;
		private CustomControl.CustomTextBox txtFirstName;
		private Label label6;
		private Label label7;
		private Label label8;
		private CustomControl.CustomTextBox customTextBox6;
		private RadioButton radioNam;
		private CustomControl.CustomTextBox txtAddress;
		private CustomControl.CustomTextBox txtPhone;
		private CustomControl.CustomTextBox txtEmail;
		private CustomControl.CustomTextBox txtLastName;
		private RadioButton radioNu;
		private RadioButton radioKhac;
		private Label lblSidePanel;
		private FontAwesome.Sharp.IconPictureBox iconCustomer;
		private Panel panelGrid;
		private DataGridView dataGridView1;
		private CustomControl.CustomTextBox txtSearchBox;
		private FontAwesome.Sharp.IconButton btnSearch;
		private Label label2;
		private ComboBox cbRole;
	}
}