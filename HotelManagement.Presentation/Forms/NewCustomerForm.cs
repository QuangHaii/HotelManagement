using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Presentation.Forms
{
	public partial class NewCustomerForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		public NewCustomerForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			TaiKhoan taiKhoan = new TaiKhoan();
			taiKhoan.UserName = txtLastName.Text + " " + txtFirstName.Text;
			taiKhoan.Password = "";
			taiKhoan.LastName = txtLastName.Text;
			taiKhoan.FirstName = txtFirstName.Text;
			taiKhoan.Email = txtEmail.Text;
			taiKhoan.Phone = txtPhone.Text;
			taiKhoan.CreatedDate = DateTime.Now;
			taiKhoan.RoleID = 3;
			_unitOfWork.TaiKhoanRepository.Add(taiKhoan);
			_unitOfWork.Save();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			var account = _unitOfWork.TaiKhoanRepository.FindByPhone(txtPhone.Text);
			txtFirstName.Text = account.FirstName;
			txtLastName.Text = account.LastName;
		}
	}
}
