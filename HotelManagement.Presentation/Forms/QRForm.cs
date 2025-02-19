using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Presentation.Forms
{
	public partial class QRForm : Form
	{
		private readonly IUnitOfWork unitOfWork;
		public QRForm(IUnitOfWork _unitOfWork, ThanhToan thanhToan = null)
		{
			InitializeComponent();
			unitOfWork = _unitOfWork;
			if (thanhToan != null)
			{
				txtSoTien.TextString = thanhToan.Total.ToString();
				txtNoiDung.TextString = "Thanh toan hoa don ID: " + thanhToan.PaymentID;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Image files (*.png)|*.png;",
				Title = "Select an Image"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedFileName = openFileDialog.FileName;
				picLogo.LoadAsync(selectedFileName);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var stk = txtSoTaiKhoan.TextString.Trim();
			var sotien = (int)double.Parse(txtSoTien.TextString.Trim());
			var noidung = txtNoiDung.TextString.Trim();
			var tentaikhoan = txtTenTaiKhoan.TextString.Trim();
			string logo = "";
			if (picLogo.Image != null)
			{
				logo = APIRequest.ImageToBase64(picLogo.Image, ImageFormat.Png);
			}

			var apiRequest = new APIRequest();
			apiRequest.acqId = 970454; // mã số ngân hàng bản việt
									   //apiRequest.accountNo = stk;
			apiRequest.accountNo = stk;
			apiRequest.accountName = tentaikhoan;
			apiRequest.amount = sotien;
			apiRequest.logo = logo;
			//apiRequest.format = "text";
			apiRequest.addInfo = noidung;
			apiRequest.template = "compact2";
			apiRequest.theme = "compact2";
			var dataResult = unitOfWork.ThanhToanRepository.generateQRCode(apiRequest);

			var image = APIRequest.Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
			picQRMOMO.Image = image;
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
			this.Close();
		}
	}
}
