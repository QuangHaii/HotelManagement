using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using HotelManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Repository
{
	public class DatPhongRepository : Repository<DatPhong>, IDatPhongRepository
	{
		private readonly ApplicationDbContext _context;
		public DatPhongRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(DatPhong datPhong)
		{
			_context.DatPhong.Update(datPhong);
		}

		public bool CheckBookingIDExist(int bookingID)
		{
			return _context.DatPhong.Any(x => x.BookingID == bookingID);
		}

		public string getCustomerName(int bookingID)
		{
			int customerID = _context.DatPhong.Where(x => x.BookingID == bookingID).Select(x => x.CustomerID).FirstOrDefault();
			return _context.TaiKhoan.Where(x=>x.AccountID == customerID).Select(x=>x.UserName).FirstOrDefault();
		}
	}
}
