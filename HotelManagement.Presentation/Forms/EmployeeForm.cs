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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Presentation.Forms
{
	public partial class EmployeeForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private List<EmployeeDTO> _employeeDTOs;
		private bool _isEdit = false;
		public EmployeeForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
			_employeeDTOs = new List<EmployeeDTO>();
			refreshList();
			HidePanel();
		}


		private void refreshList()
		{
			var list = _unitOfWork.TaiKhoanRepository.GetAllEmployees();
			_employeeDTOs.Clear();
			foreach (var employee in list)
			{
				var role = _unitOfWork.PhanQuyenRepository.GetById(employee.RoleID);
				_employeeDTOs.Add(new EmployeeDTO()
				{
					ID = employee.AccountID,
					HọVàTên = employee.LastName + " " + employee.FirstName,
					Tên = employee.FirstName,
					TênĐệm = employee.LastName,
					GiớiTính = employee.Gender,
					SốĐiệnThoại = employee.Phone,
					Email = employee.Email.Replace("@", "\n@"),
					ĐịaChỉ = employee.Address,
					CôngViệc = role.RoleName,
					MôTả = role.Description
				});
			}
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = _employeeDTOs;
		}
		private void HidePanel()
		{
			panelSide.Width = 0;
			panelTop.Enabled = true;
			txtAddress.TextString = "";
			txtEmail.TextString = "";
			txtFirstName.TextString = "";
			txtLastName.TextString = "";
			txtPhone.TextString = "";
			radioNam.Checked = false;
			radioNu.Checked = false;
			radioKhac.Checked = true;
			cbRole.DataSource = _unitOfWork.PhanQuyenRepository.GetEmployeeRoles();
		}
		private void ShowPanel()
		{
			panelSide.Width = 300;
			panelTop.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblSidePanel.Text = "Thêm Nhân Viên";
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
			if (!IsValidName(txtFirstName.TextString) || !IsValidName(txtLastName.TextString))
			{
				MessageBox.Show("Tên không hợp lệ");
				return;
			}
			if (!IsValidEmail(txtEmail.TextString))
			{
				MessageBox.Show("Email không hợp lệ");
				return;
			}
			if (!IsValidPhoneNumber(txtPhone.TextString))
			{
				MessageBox.Show("Số điện thoại không hợp lệ");
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
			taiKhoan.RoleID = _unitOfWork.PhanQuyenRepository.FindRoleID(cbRole.Text);
			taiKhoan.Status = "Hoạt Động";
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
			refreshList();
			HidePanel();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			refreshList();
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
			lblSidePanel.Text = "Sửa Nhân Viên";
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
			cbRole.SelectedItem = _unitOfWork.PhanQuyenRepository.FindRoleName(taiKhoan.RoleID);
			_isEdit = true;
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			int ID = GetIDFromTable();
			if (ID == -1)
				return;
			DialogResult result = MessageBox.Show("Bạn có muốn xóa ID: " + ID + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				MessageBox.Show("Xóa thành công!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_unitOfWork.TaiKhoanRepository.Remove(ID);
				_unitOfWork.Save();
				refreshList();
			}
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			string searchText = txtSearchBox.TextString;
			if (string.IsNullOrWhiteSpace(searchText))
			{
				refreshList();
				return;
			}
			var filteredList = _employeeDTOs
		   .Where(c => c.HọVàTên.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
					   c.SốĐiệnThoại.Contains(searchText) ||
					   c.Email.Contains(searchText, StringComparison.OrdinalIgnoreCase))
		   .ToList();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = filteredList;
		}
		static bool IsValidEmail(string email)
		{
			string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			Regex regex = new Regex(pattern);
			return regex.IsMatch(email);
		}
		static bool IsValidPhoneNumber(string phoneNumber)
		{
			string pattern = @"^\d{10,15}$";
			Regex regex = new Regex(pattern);
			return regex.IsMatch(phoneNumber);
		}
		static bool IsValidName(string name)
		{
			string pattern = @"^[\p{L}\s'-]{2,50}$";
			Regex regex = new Regex(pattern);

			return regex.IsMatch(name);
		}
	}
}
