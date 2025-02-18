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
	public partial class ServiceForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private List<ServiceDTO> servicesDTO;
		private List<string> serviceList;

		private bool _isEdit = false;
		public ServiceForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
			servicesDTO = new List<ServiceDTO>();
			serviceList = unitOfWork.LoaiDichVuRepository.GetAll().Select(c => c.RoomServiceName).ToList();
			cbService.DataSource = serviceList;
			refreshList();
			HidePanel();
		}


		private void refreshList()
		{
			//Load room list from database
			var list = _unitOfWork.DichVuRepository.GetAll();
			servicesDTO.Clear();
			foreach (var service in list)
			{
				var name = _unitOfWork.LoaiDichVuRepository.GetById(service.RoomServiceID).RoomServiceName;
				servicesDTO.Add(new ServiceDTO()
				{
					IDĐơnDịchVụ = service.ServiceID,
					IDLoạiDịchVụ = service.RoomServiceID,
					BookingID = service.BookingID,
					TênDịchVụ = name,
					NgàyTạo = service.CreatedDate,
					MôTả = service.Description
				});
			}
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = servicesDTO;
		}
		private void HidePanel()
		{
			panelSide.Width = 0;
			panelTop.Enabled = true;
			txtBookingID.TextString = "";
			txtDescription.TextString = "";
		}
		private void ShowPanel()
		{
			panelSide.Width = 300;
			panelTop.Enabled = false;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblSidePanel.Text = "Thêm Dịch Vụ";
			ShowPanel();
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			HidePanel();
			_isEdit = false;
		}
		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (txtBookingID.TextString == "" || txtDescription.TextString == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}

			DichVu dichVu = new DichVu();
			if (_isEdit)
			{
				int ID = GetIDFromTable();
				dichVu = _unitOfWork.DichVuRepository.GetById(ID);
			}
			if(!_unitOfWork.DatPhongRepository.CheckBookingIDExist(Convert.ToInt32(txtBookingID.TextString)))
			{
				MessageBox.Show("ID Booking không tồn tại!");
				return;
			}
			dichVu.BookingID = Convert.ToInt32(txtBookingID.TextString);
			dichVu.Description = txtDescription.TextString;
			dichVu.RoomServiceID = _unitOfWork.LoaiDichVuRepository.GetServiceTypeID(cbService.Text);
			dichVu.CreatedDate = DateTime.Now;
			if (_isEdit)
			{
				_unitOfWork.DichVuRepository.Update(dichVu);
				MessageBox.Show("Sửa thành công!");
				_isEdit = false;
			}
			else
			{
				_unitOfWork.DichVuRepository.Add(dichVu);
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
				int id = Convert.ToInt32(selectedRow.Cells["IDĐơnDịchVụ"].Value);
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
			DichVu dichVu = _unitOfWork.DichVuRepository.GetById(ID);
			lblSidePanel.Text = "Sửa Thông Tin Dịch Vụ";
			ShowPanel();
			txtBookingID.TextString = dichVu.BookingID.ToString();
			txtDescription.TextString = dichVu.Description;
			cbService.SelectedItem = _unitOfWork.LoaiDichVuRepository.GetById(dichVu.RoomServiceID).RoomServiceName;
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
				_unitOfWork.DichVuRepository.Remove(ID);
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
			var filteredList = servicesDTO
		   .Where(c => c.TênDịchVụ.Contains(searchText)
					|| c.BookingID.ToString().Contains(searchText)
					|| c.IDLoạiDịchVụ.ToString().Contains(searchText))
		   .ToList();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = filteredList;
		}
	}
}
