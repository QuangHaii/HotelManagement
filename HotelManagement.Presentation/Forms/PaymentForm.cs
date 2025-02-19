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
	public partial class PaymentForm : Form
	{
		private readonly IUnitOfWork _unitOfWork;
		private List<PaymentDTO> paymentDTO;
		private List<RoomServiceDTO> roomServiceDTO;
		private List<string> paymentMethod = new List<string> { "Chuyển khoản", "Tiền mặt" };
		private List<string> statusList = new List<string> { "Đã thanh toán", "Chưa thanh toán" };
		private bool _isEdit = false;
		public PaymentForm(IUnitOfWork unitOfWork)
		{
			InitializeComponent();
			_unitOfWork = unitOfWork;
			paymentDTO = new List<PaymentDTO>();
			roomServiceDTO = new List<RoomServiceDTO>();
			cbStatus.DataSource = statusList;
			cbMethod.DataSource = paymentMethod;
			refreshList();
			HidePanel();
		}


		private void refreshList()
		{
			var list = _unitOfWork.ThanhToanRepository.GetAll();
			paymentDTO.Clear();
			foreach (var payment in list)
			{
				var customerName = _unitOfWork.DatPhongRepository.getCustomerName(payment.BookingID);
				paymentDTO.Add(new PaymentDTO()
				{
					IDThanhToán = payment.PaymentID,
					IDBooking = payment.BookingID,
					TênKháchHàng = customerName,
					TổngTiền = payment.Total,
					PhươngThức = payment.PaymentMethod,
					NgàyThanhToán = payment.PaymentDate,
					TrạngThái = payment.PaymentStatus,
					GhiChú = payment.Description
				});
			}
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = paymentDTO;
		}
		private void HidePanel()
		{
			panelSide.Width = 0;
			panelTop.Enabled = true;

			txtID.TextString = "";
			txtName.TextString = "";
			txtPrice.TextString = "";
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
			if (txtName.TextString == "" || txtPrice.TextString == "" || txtID.TextString == "" || txtNote.TextString == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			if (!IsValidName(txtName.TextString) || !IsValidPositiveDecimal(txtPrice.TextString) || !IsValidPositiveInteger(txtID.TextString))
			{
				MessageBox.Show("Thông tin không hợp lệ");
				return;
			}


			var bookingID = Convert.ToInt32(txtID.TextString);
			if (!_unitOfWork.DatPhongRepository.CheckBookingIDExist(bookingID))
			{
				MessageBox.Show("Không tìm thấy ID");
				return;
			}

			ThanhToan thanhToan = new ThanhToan();
			if (_isEdit)
			{
				int ID = GetIDFromTable();
				thanhToan = _unitOfWork.ThanhToanRepository.GetById(ID);
			}
			thanhToan.BookingID = bookingID;
			thanhToan.Total = Convert.ToDecimal(txtPrice.TextString);
			thanhToan.PaymentDate = datePayment.Value;
			thanhToan.PaymentStatus = cbStatus.Text;
			thanhToan.PaymentMethod = cbMethod.Text;
			thanhToan.Description = txtNote.TextString;
			if (_isEdit)
			{
				_unitOfWork.ThanhToanRepository.Update(thanhToan);
				MessageBox.Show("Sửa thành công!");
				_isEdit = false;
			}
			else
			{
				_unitOfWork.ThanhToanRepository.Add(thanhToan);
				MessageBox.Show("Thêm thành công!");
			}
			_unitOfWork.Save();
			refreshList();
			HidePanel();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			int ID = GetIDFromTable();
			var thanhToan = _unitOfWork.ThanhToanRepository.GetById(ID);
			QRForm qRForm = new QRForm(_unitOfWork,thanhToan);
			qRForm.ShowDialog();
		}
		private int GetIDFromTable()
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				int id = Convert.ToInt32(selectedRow.Cells["IDThanhToán"].Value);
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
			ThanhToan thanhToan = _unitOfWork.ThanhToanRepository.GetById(ID);
			lblSidePanel.Text = "Sửa Thông Tin";
			ShowPanel();
			txtID.TextString = thanhToan.BookingID.ToString();
			txtName.TextString = _unitOfWork.DatPhongRepository.getCustomerName(thanhToan.BookingID);
			txtPrice.TextString = thanhToan.Total.ToString();
			txtNote.TextString = thanhToan.Description;
			cbMethod.SelectedItem = thanhToan.PaymentMethod;
			datePayment.Value = thanhToan.PaymentDate;
			cbStatus.SelectedItem = thanhToan.PaymentStatus;

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
				_unitOfWork.ThanhToanRepository.Remove(ID);
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
			var filteredList = paymentDTO
		   .Where(c => c.TênKháchHàng.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
					   c.TrạngThái.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
					   c.PhươngThức.Contains(searchText, StringComparison.OrdinalIgnoreCase))
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
		public bool IsValidPositiveDecimal(string input)
		{
			if (decimal.TryParse(input, out decimal number) && number > 0)
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

		private void btnSearchID_Click(object sender, EventArgs e)
		{
			if (IsValidPositiveInteger(txtID.TextString) == false)
			{
				MessageBox.Show("ID không hợp lệ");
				return;
			}
			int ID = Convert.ToInt32(txtID.TextString);
			if (!_unitOfWork.DatPhongRepository.CheckBookingIDExist(ID))
			{
				MessageBox.Show("Không tìm thấy ID");
				return;
			}
			else
			{
				var servicePrice = _unitOfWork.DichVuRepository.totalServicePrice(ID);
				var roomPrice = _unitOfWork.PhongRepository.getPriceByBookingID(ID);
				txtName.TextString = _unitOfWork.DatPhongRepository.getCustomerName(ID);
				txtPrice.TextString = (servicePrice + roomPrice).ToString();
			}
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				int id = Convert.ToInt32(selectedRow.Cells["IDBooking"].Value);
				roomServiceDTO.Clear();
				var list = _unitOfWork.DichVuRepository.GetServiceListByBookingID(id);
				foreach (var item in list) 
				{
					roomServiceDTO.Add(new RoomServiceDTO()
					{
						TênDịchVụ = item.Item1,
						Giá = item.Item2,
						NgàyTạo = item.Item3,
						GhiChú = item.Item4
					});
				}
				dataGridView2.DataSource = null;
				dataGridView2.DataSource = roomServiceDTO;
			}
		}
	}
}
