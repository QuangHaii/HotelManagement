using HotelManagement.Application.Interfaces;
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

namespace HotelManagement.Presentation.Forms
{
	public partial class LoginForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		public LoginForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void btnMini_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void customButton1_Click(object sender, EventArgs e)
		{
			if(txtEmail.TextString == "" || txtPassword.TextString == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
				return;
			}

			var account = _unitOfWork.TaiKhoanRepository.FindByEmail(txtEmail.TextString);
			if (account == null)
			{
				MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
				return;
			}
			if (account.Password != txtPassword.TextString)
			{
				MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
				return;
			}
			if (account.RoleID == 3)
			{
				MessageBox.Show("Tài khoản không có quyền truy cập!");
				return;
			}
			MessageBox.Show("Đăng nhập thành công !");
			FormMain formMain = new FormMain(_unitOfWork,account);
			formMain.Show();
			this.Hide();
		}
	}
}
