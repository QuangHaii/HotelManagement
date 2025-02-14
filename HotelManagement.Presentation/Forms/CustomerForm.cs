using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using HotelManagement.Presentation.DTO;
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
	public partial class CustomerForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private List<CustomerDTO> _customerDTOs;
		private bool _isEdit = false;
		public CustomerForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
			_customerDTOs = new List<CustomerDTO>();
			refreshCustomerList();
			HidePanel();
		}

		private void refreshCustomerList()
		{
			var list = _unitOfWork.TaiKhoanRepository.GetAllCustomers();
			_customerDTOs.Clear();
			foreach (var customer in list)
			{
				_customerDTOs.Add(new CustomerDTO()
				{
					ID = customer.AccountID,
					HọVàTên = customer.LastName + " " + customer.FirstName,
					TênKháchHàng = customer.FirstName,
					TênĐệm = customer.LastName,
					GiớiTính = customer.Gender,
					SốĐiệnThoại = customer.Phone,
					Email = customer.Email.Replace("@", "\n@"),
					ĐịaChỉ = customer.Address
				});
			}
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = _customerDTOs;
			dataGridView1.ClearSelection();
		}

		private void HidePanel()
		{
			panelSide.Width = 0;
			panelTop.Enabled = true;
		}

		private void ShowPanel()
		{
			panelSide.Width = 300;
			panelTop.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			ShowPanel();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			HidePanel();
			_isEdit = false;
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (txtAddress.TextString == "" || txtEmail.TextString == "" || txtFirstName.TextString == "" || txtLastName.TextString == "" || txtPhone.TextString == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			TaiKhoan taiKhoan = new TaiKhoan();
			if (_isEdit)
			{
				int ID = GetIDFromTable();
				taiKhoan = _unitOfWork.TaiKhoanRepository.GetById(ID);
			}
			taiKhoan.UserName = txtLastName.TextString + " " + txtFirstName.TextString;
			taiKhoan.Password = "";
			taiKhoan.LastName = txtLastName.TextString;
			taiKhoan.FirstName = txtFirstName.TextString;
			taiKhoan.Email = txtEmail.TextString;
			taiKhoan.Phone = txtPhone.TextString;
			taiKhoan.Address = txtAddress.TextString;
			taiKhoan.CreatedDate = DateTime.Now;
			taiKhoan.RoleID = 3;
			//Get selected radio button
			string selectedText = "";
			if (radioNam.Checked)
				selectedText = radioNam.Text;
			else if (radioNu.Checked)
				selectedText = radioNu.Text;
			else if (radioKhac.Checked)
				selectedText = radioKhac.Text;
			taiKhoan.Gender = selectedText;

			if (_isEdit)
			{
				_unitOfWork.TaiKhoanRepository.Update(taiKhoan);
				MessageBox.Show("Sửa thành công!");
				_isEdit = false;
			}
			else
			{
				_unitOfWork.TaiKhoanRepository.Add(taiKhoan);
				MessageBox.Show("Thêm thành công!");
			}
			_unitOfWork.Save();
			refreshCustomerList();
			HidePanel();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			refreshCustomerList();
		}

		private int GetIDFromTable()
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
				return id;
			}
			else
			{
				MessageBox.Show("No row is selected.");
				return -1;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			int ID = GetIDFromTable();
			if (ID == -1)
				return;
			TaiKhoan taiKhoan = _unitOfWork.TaiKhoanRepository.GetById(ID);
			ShowPanel();
			txtAddress.TextString = taiKhoan.Address;
			txtEmail.TextString = taiKhoan.Email;
			txtFirstName.TextString = taiKhoan.FirstName;
			txtLastName.TextString = taiKhoan.LastName;
			txtPhone.TextString = taiKhoan.Phone;
			if (taiKhoan.Gender == "Nam")
				radioNam.Checked = true;
			else if (taiKhoan.Gender == "Nữ")
				radioNu.Checked = true;
			else if (taiKhoan.Gender == "Khác")
				radioKhac.Checked = true;
			_isEdit = true;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int ID = GetIDFromTable();
			if (ID == -1)
				return;
			_unitOfWork.TaiKhoanRepository.Remove(ID);
			_unitOfWork.Save();
			refreshCustomerList();
			MessageBox.Show("Xóa thành công!");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string searchText = txtSearchBox.TextString;
			if (string.IsNullOrWhiteSpace(searchText))
			{
				refreshCustomerList();
				return;
			}
			var filteredList = _customerDTOs
		   .Where(c => c.HọVàTên.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
					   c.SốĐiệnThoại.Contains(searchText) ||
					   c.Email.Contains(searchText, StringComparison.OrdinalIgnoreCase))
		   .ToList();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = filteredList;
		}
	}
}
