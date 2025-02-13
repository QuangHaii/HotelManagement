using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using HotelManagement.Presentation.Forms;

namespace HotelManagement.Presentation
{
	public partial class FormMain : Form
	{
		private IconButton currentBtn;
		private Panel leftBorderBtn;
		private Form currentChildForm;
		private readonly IUnitOfWork _unitOfWork;
		private TaiKhoan _currentUser;
		public FormMain(IUnitOfWork unitOfWork, TaiKhoan currentUser)
		{
			InitializeComponent();
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			panelMenu.Controls.Add(leftBorderBtn);
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			_unitOfWork = unitOfWork;
			_currentUser = currentUser;
			txtCurrentUser.Text = "User: " + _currentUser.UserName;
			txtName.Text = _currentUser.LastName + " " + _currentUser.FirstName;
		}

		private void ActiveButton(object senderBtn)
		{
			if (senderBtn != null)
			{
				DisableButton();
				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Color.FromArgb(30, 90, 168);
				currentBtn.ForeColor = Color.FromArgb(78, 205, 196);
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = Color.FromArgb(78, 205, 196);
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;

				leftBorderBtn.BackColor = Color.FromArgb(78, 205, 196);
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();

				iconCurrentChildForm.IconChar = currentBtn.IconChar;
				iconCurrentChildForm.IconColor = Color.FromArgb(240, 243, 249);
				lblTitleChildForm.Text = currentBtn.Text;
			}
		}

		private void DisableButton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(14, 36, 66);
				currentBtn.ForeColor = Color.White;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.White;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}

		private void OpenChildForm(Form childForm)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Dock = DockStyle.Fill;
			childForm.Show();
		}

		private void btnTrangChu_Click(object sender, EventArgs e)
		{
			ActiveButton(sender);
			OpenChildForm(new NewCustomerForm(_unitOfWork));
		}

		private void btnKhachHang_Click(object sender, EventArgs e)
		{
			ActiveButton(sender);
		}

		private void btnPhong_Click(object sender, EventArgs e)
		{
			ActiveButton(sender);
		}

		private void btnDichVu_Click(object sender, EventArgs e)
		{
			ActiveButton(sender);
		}

		private void btnHoaDon_Click(object sender, EventArgs e)
		{
			ActiveButton(sender);
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;
			iconCurrentChildForm.IconChar = IconChar.Home;
			iconCurrentChildForm.IconColor = Color.White;
			lblTitleChildForm.Text = "Trang chủ";
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
			checkCurrentWindowState();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void btnSize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
			checkCurrentWindowState();
		}

		private void btnMini_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void checkCurrentWindowState()
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				btnSize.IconChar = IconChar.Minimize;
			}
			else
			{
				btnSize.IconChar = IconChar.Maximize;
			}
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm(_unitOfWork);
			loginForm.Show();
			this.Close();
		}
	}
}
