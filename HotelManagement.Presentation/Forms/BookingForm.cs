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
	public partial class BookingForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private List<BookingDTO> bookingDTOs;
		private List<string> roomTypeList;
		private List<string> roomList;
		private List<string> statusList = new List<string> { "Đã đặt", "Đã nhận", "Đã hủy", "Hoàn thành" };
		private bool _isEdit = false;
		public BookingForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
			bookingDTOs = new List<BookingDTO>();
			cbStatus.DataSource = statusList;
			refreshList();
			HidePanel();
		}


		private void refreshList()
		{
			var list = _unitOfWork.DatPhongRepository.GetAll();
			bookingDTOs.Clear();
			foreach (var booking in list)
			{
				var room = _unitOfWork.PhongRepository.GetById(booking.RoomID);
				bookingDTOs.Add(new BookingDTO()
				{
					BookingID = booking.BookingID,
					TênKháchHàng = _unitOfWork.TaiKhoanRepository.GetById(booking.CustomerID).UserName,
					SốPhòng = room.RoomNumber,
					LoạiPhòng = _unitOfWork.LoaiPhongRepository.GetById(room.RoomTypeID).RoomTypeName,
					NgàyNhậnPhòng = booking.CheckInDate,
					NgàyTrảPhòng = booking.CheckOutDate,
					TrạngThái = booking.BookingStatus,
					NgàyTạo = booking.CreatedDate
				});
			}
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = bookingDTOs;
		}
		private void HidePanel()
		{
			panelSide.Width = 0;
			panelTop.Enabled = true;

			txtID.TextString = "";
			txtName.TextString = "";
			txtNum.TextString = "";

			roomTypeList = _unitOfWork.LoaiPhongRepository.GetAll().Select(r => r.RoomTypeName).ToList();
			cbRoomType.DataSource = roomTypeList;
			cbRoomType.SelectedIndex = 0;

			var roomID = _unitOfWork.LoaiPhongRepository.getRoomTypeID(cbRoomType.Text);
			roomList = _unitOfWork.PhongRepository.getListRoomNameByRoomType(roomID);
			cbRoomNum.DataSource = roomList;
		}
		private void ShowPanel()
		{
			panelSide.Width = 300;
			panelTop.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblSidePanel.Text = "Thêm Thông Tin";
			ShowPanel();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			HidePanel();
			_isEdit = false;
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (txtName.TextString == "" || txtNum.TextString == "" || txtID.TextString == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			if (!IsValidName(txtName.TextString) || !IsValidPositiveInteger(txtNum.TextString) || !IsValidPositiveInteger(txtID.TextString))
			{
				MessageBox.Show("Tên không hợp lệ");
				return;
			}
            if (dateCheckOut.Value <= dateCheckIn.Value)
            {
				MessageBox.Show("Ngày nhận phòng và trả phòng không hợp lệ");
				return;
			}
			
			var customerID = Convert.ToInt32(txtID.TextString);
			if (!_unitOfWork.TaiKhoanRepository.checkCustomerExist(customerID))
			{
				MessageBox.Show("Không tìm thấy ID");
				return;
			}

			DatPhong datPhong = new DatPhong();
			var currentRoomID = _unitOfWork.PhongRepository.getRoomIDByRoomNumber(cbRoomNum.Text);
			if (_isEdit)
			{
				int ID = GetIDFromTable();
				datPhong = _unitOfWork.DatPhongRepository.GetById(ID);
				if (_unitOfWork.PhongRepository.GetById(currentRoomID).Status == "Đã đặt" && datPhong.RoomID != currentRoomID)
				{
					MessageBox.Show("Phòng " + cbRoomNum.Text + " không còn trống!");
					return;
				}
				if (datPhong.RoomID != currentRoomID)
				{
					var oldRoom = _unitOfWork.PhongRepository.GetById(datPhong.RoomID);
					oldRoom.Status = "Trống";
					_unitOfWork.PhongRepository.Update(oldRoom);
				}
			}
			datPhong.CustomerID = customerID;
			datPhong.RoomID = currentRoomID;
			datPhong.CheckInDate = dateCheckIn.Value;
			datPhong.CheckOutDate = dateCheckOut.Value;
			datPhong.BookingStatus = cbStatus.Text;
			datPhong.CreatedDate = DateTime.Now;
			datPhong.NumberOfGuest = Convert.ToInt32(txtNum.TextString);

			var room = _unitOfWork.PhongRepository.GetById(datPhong.RoomID);
			room.Status = "Đã đặt";

			if (_isEdit)
			{
				_unitOfWork.DatPhongRepository.Update(datPhong);
				MessageBox.Show("Sửa thành công!");
				_isEdit = false;
			}
			else
			{
				_unitOfWork.DatPhongRepository.Add(datPhong);
				MessageBox.Show("Thêm thành công!");
			}
			_unitOfWork.PhongRepository.Update(room);
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
				int id = Convert.ToInt32(selectedRow.Cells["BookingID"].Value);
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
			DatPhong datPhong = _unitOfWork.DatPhongRepository.GetById(ID);
			lblSidePanel.Text = "Sửa Thông Tin";
			ShowPanel();
			txtID.TextString = datPhong.CustomerID.ToString();
			txtName.TextString = _unitOfWork.TaiKhoanRepository.GetById(datPhong.CustomerID).UserName;
			txtNum.TextString = datPhong.NumberOfGuest.ToString();
			var room = _unitOfWork.PhongRepository.GetById(datPhong.RoomID);
			cbRoomType.SelectedItem = _unitOfWork.LoaiPhongRepository.GetById(room.RoomTypeID).RoomTypeName;
			cbRoomNum.SelectedItem = room.RoomNumber;
			dateCheckIn.Value = datPhong.CheckInDate;
			dateCheckOut.Value = datPhong.CheckOutDate;
			cbStatus.SelectedItem = datPhong.BookingStatus;
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
				_unitOfWork.DatPhongRepository.Remove(ID);
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
			var filteredList = bookingDTOs
		   .Where(c => c.TênKháchHàng.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
					   c.SốPhòng.Contains(searchText) ||
					   c.TrạngThái.Contains(searchText, StringComparison.OrdinalIgnoreCase))
		   .ToList();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = filteredList;
		}
		public bool IsValidPositiveInteger(string input)
		{
			if (int.TryParse(input, out int number) && number > 0)
			{
				return true;
			}
			return false;
		}
		static bool IsValidName(string name)
		{
			string pattern = @"^[\p{L}\s'-]{2,50}$";
			Regex regex = new Regex(pattern);

			return regex.IsMatch(name);
		}

		private void cbRoomType_SelectedValueChanged(object sender, EventArgs e)
		{
			var roomID = _unitOfWork.LoaiPhongRepository.getRoomTypeID(cbRoomType.Text);
			roomList = _unitOfWork.PhongRepository.getListRoomNameByRoomType(roomID);
			cbRoomNum.DataSource = roomList;
		}

		private void btnSearchID_Click(object sender, EventArgs e)
		{
			if(IsValidPositiveInteger(txtID.TextString) == false)
			{
				MessageBox.Show("ID không hợp lệ");
				return;
			}
			int ID = Convert.ToInt32(txtID.TextString);
			if(!_unitOfWork.TaiKhoanRepository.checkCustomerExist(ID))
			{
				MessageBox.Show("Không tìm thấy ID");
				return;
			} else
			{
				txtName.TextString = _unitOfWork.TaiKhoanRepository.GetById(ID).UserName;
			}
		}
	}
}
