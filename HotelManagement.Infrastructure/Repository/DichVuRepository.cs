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
	public class DichVuRepository : Repository<DichVu>, IDichVuRepository
	{
		private readonly ApplicationDbContext _context;
		public DichVuRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public List<Tuple<string,decimal,DateTime,string>> GetServiceListByBookingID(int bookingID)
		{
			var result = from dv in _context.DichVu
						 join ldv in _context.LoaiDichVu on dv.RoomServiceID equals ldv.RoomServiceID
						 where dv.BookingID == bookingID
						 select new Tuple<string, decimal, DateTime, string>(ldv.RoomServiceName, ldv.Price,dv.CreatedDate,dv.Description);

			return result.ToList();
		}

		public decimal totalServicePrice(int bookingID)
		{
			return (from dv in _context.DichVu
					join ldv in _context.LoaiDichVu on dv.RoomServiceID equals ldv.RoomServiceID
					where dv.BookingID == bookingID
					select ldv.Price).Sum();
		}

		public void Update(DichVu dichVu)
		{
			_context.DichVu.Update(dichVu);
		}
	}
}
