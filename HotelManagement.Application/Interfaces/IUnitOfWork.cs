using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Interfaces
{
	public interface IUnitOfWork
	{
		IDatPhongRepository DatPhongRepository { get; }
		ITaiKhoanRepository TaiKhoanRepository { get; }
		ILoaiPhongRepository LoaiPhongRepository { get; }
		IPhongRepository PhongRepository { get; }
		IThanhToanRepository ThanhToanRepository { get; }
		IPhanQuyenRepository PhanQuyenRepository { get; }
		ILoaiDichVuRepository LoaiDichVuRepository { get; }
		IDichVuRepository DichVuRepository { get; }
		void Save();
	}
}
