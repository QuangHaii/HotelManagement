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
	public partial class ServiceTypeForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private List<ServiceTypeDTO> serviceTypeDTOs;

		private bool _isEdit = false;
		public ServiceTypeForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
			serviceTypeDTOs = new List<ServiceTypeDTO>();
			refreshList();
			HidePanel();
		}


		private void refreshList()
		{
			//Load room list from database
			var list = _unitOfWork.LoaiDichVuRepository.GetAll();
			serviceTypeDTOs.Clear();
			foreach (var type in list)
			{
				serviceTypeDTOs.Add(new ServiceTypeDTO()
				{
					IDLoạiDịchVụ = type.RoomServiceID,
					TênDịchVụ = type.RoomServiceName,
					MôTả = type.Description,
					Giá = type.Price
				});
			}
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = serviceTypeDTOs;
		}
		private void HidePanel()
		{
			panelSide.Width = 0;
			panelTop.Enabled = true;
			txtTypeName.TextString = "";
			txtPrice.TextString = "";
			txtDescription.TextString = "";
		}
		private void ShowPanel()
		{
			panelSide.Width = 300;
			panelTop.Enabled = false;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblSidePanel.Text = "Thêm Loại Dịch Vụ";
			ShowPanel();
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			HidePanel();
			_isEdit = false;
		}
		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (txtTypeName.TextString == "" || txtPrice.TextString == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			if (!IsValidNonNegativeInteger(txtPrice.TextString))
			{
				MessageBox.Show("Số không hợp lệ");
				return;
			}

			LoaiDichVu dichVu = new LoaiDichVu();
			if (_isEdit)
			{
				int ID = GetIDFromTable();
				dichVu = _unitOfWork.LoaiDichVuRepository.GetById(ID);
			}
			dichVu.RoomServiceName = txtTypeName.TextString;
			dichVu.Price = Convert.ToDecimal(txtPrice.TextString);
			dichVu.Description = txtDescription.TextString;
			if (_isEdit)
			{
				_unitOfWork.LoaiDichVuRepository.Update(dichVu);
				MessageBox.Show("Sửa thành công!");
				_isEdit = false;
			}
			else
			{
				_unitOfWork.LoaiDichVuRepository.Add(dichVu);
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
				int id = Convert.ToInt32(selectedRow.Cells["IDLoạiDịchVụ"].Value);
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
			LoaiDichVu dichVu = _unitOfWork.LoaiDichVuRepository.GetById(ID);
			lblSidePanel.Text = "Sửa Thông Tin Dịch Vụ";
			ShowPanel();
			txtTypeName.TextString = dichVu.RoomServiceName;
			txtPrice.TextString = dichVu.Price.ToString();
			txtDescription.TextString = dichVu.Description;
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
				_unitOfWork.LoaiDichVuRepository.Remove(ID);
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
			var filteredList = serviceTypeDTOs
		   .Where(c => c.TênDịchVụ.Contains(searchText)
					|| c.Giá.ToString().Contains(searchText))
		   .ToList();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = filteredList;
		}
		static bool IsValidNonNegativeInteger(string input)
		{
			return decimal.TryParse(input, out decimal number) && number >= 0;
		}
	}
}
