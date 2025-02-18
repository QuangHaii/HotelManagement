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
	public partial class RoomForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private List<RoomDTO> _roomDTOS;
		private List<RoomAvailabilityDTO> _roomAvailabilityDTOS;
		private List<string> statusList = new List<string> { "Trống", "Đã đặt", "Đã nhận"};
		private bool _isEdit = false;
		public RoomForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
			_roomDTOS = new List<RoomDTO>();
			_roomAvailabilityDTOS = new List<RoomAvailabilityDTO>();
			refreshList();
			HidePanel();
		}


		private void refreshList()
		{
			//Load room list from database
			var list = _unitOfWork.PhongRepository.GetAll();
			_roomDTOS.Clear();
			foreach (var room in list)
			{
				var roomType = _unitOfWork.LoaiPhongRepository.GetById(room.RoomTypeID);
				_roomDTOS.Add(new RoomDTO()
				{
					IDPhòng = room.RoomID,
					IDLoạiPhòng = room.RoomTypeID,
					SốPhòng = room.RoomNumber,
					SốTầng = room.Floor,
					TrạngThái = room.Status,
					LoạiPhòng = roomType.RoomTypeName,
					SốLượngNgười = roomType.Capacity,
					Giá = roomType.Price.ToString(),
					MôTả = roomType.Description
				});
			}
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = _roomDTOS;

			//Load avaialble room list from database
			_roomAvailabilityDTOS.Clear();
			var roomAvailable = _unitOfWork.PhongRepository.getRoomAvailable();
			foreach (var room in roomAvailable)
			{
				var roomType = _unitOfWork.LoaiPhongRepository.GetById(room.Item1);
				_roomAvailabilityDTOS.Add(new RoomAvailabilityDTO()
				{
					IDLoạiPhòng = room.Item1,
					TênLoạiPhòng = roomType.RoomTypeName,
					PhòngCònTrống = room.Item2
				});
			}
			dataGridView2.DataSource = null;
			dataGridView2.DataSource = _roomAvailabilityDTOS;
		}
		private void HidePanel()
		{
			panelSide.Width = 0;
			panelTop.Enabled = true;
			txtRoomNum.TextString = "";
			txtFloor.TextString = "";
			cbRoomType.DataSource = _unitOfWork.LoaiPhongRepository.getListRoomType();
			cbRoomStatus.DataSource = statusList;
		}
		private void ShowPanel()
		{
			panelSide.Width = 300;
			panelTop.Enabled = false;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblSidePanel.Text = "Thêm Phòng";
			ShowPanel();
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			HidePanel();
			_isEdit = false;
		}
		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (txtRoomNum.TextString == "" || txtFloor.TextString == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			if (!IsValidRoomCode(txtRoomNum.TextString) || !IsValidNonNegativeInteger(txtFloor.TextString))
			{
				MessageBox.Show("Số không hợp lệ");
				return;
			}

			Phong phong = new Phong();
			if (_isEdit)
			{
				int ID = GetIDFromTable();
				phong = _unitOfWork.PhongRepository.GetById(ID);
			}
			phong.RoomNumber = txtRoomNum.TextString;
			phong.Floor = Convert.ToInt32(txtFloor.TextString);
			phong.Status = cbRoomStatus.Text;
			phong.RoomTypeID = _unitOfWork.LoaiPhongRepository.getRoomTypeID(cbRoomType.Text);

			if (_isEdit)
			{
				_unitOfWork.PhongRepository.Update(phong);
				MessageBox.Show("Sửa thành công!");
				_isEdit = false;
			}
			else
			{
				_unitOfWork.PhongRepository.Add(phong);
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
				int id = Convert.ToInt32(selectedRow.Cells["IDPhòng"].Value);
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
			Phong phong = _unitOfWork.PhongRepository.GetById(ID);
			lblSidePanel.Text = "Sửa Thông Tin Phòng";
			ShowPanel();
			txtRoomNum.TextString = phong.RoomNumber.ToString();
			txtFloor.TextString = phong.Floor.ToString();
			cbRoomType.Text = _unitOfWork.LoaiPhongRepository.getRoomTypeName(phong.RoomTypeID);
			cbRoomStatus.Text = phong.Status;
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
				_unitOfWork.PhongRepository.Remove(ID);
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
			var filteredList = _roomDTOS
		   .Where(c => c.SốPhòng.Contains(searchText) || 
						c.LoạiPhòng.Contains(searchText) || 
						c.TrạngThái.Contains(searchText) || 
						c.SốTầng.ToString().Contains(searchText))
		   .ToList();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = filteredList;
		}
		static bool IsValidNonNegativeInteger(string input)
		{
			return int.TryParse(input, out int number) && number >= 0;
		}
		public static bool IsValidRoomCode(string input)
		{
			return Regex.IsMatch(input, @"^[A-Z]\d{3}$");
		}
	}
}
