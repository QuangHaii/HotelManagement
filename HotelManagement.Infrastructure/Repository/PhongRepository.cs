using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using HotelManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Repository
{
	public class PhongRepository : Repository<Phong>, IPhongRepository
	{
		private readonly ApplicationDbContext _context;
		public PhongRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public List<string> getListRoomNameByRoomType(int roomTypeID)
		{
			return _context.Phong
				.Where(p => p.RoomTypeID == roomTypeID)
				.Select(p => p.RoomNumber)
				.ToList();
		}

		public decimal getPriceByBookingID(int bookingID)
		{
			var result = from p in _context.Phong
						 join rt in _context.LoaiPhong on p.RoomTypeID equals rt.RoomTypeID
						 join b in _context.DatPhong on p.RoomID equals b.RoomID
						 where b.BookingID == bookingID
						 select rt.Price;
			return result.FirstOrDefault();
		}

		public List<Tuple<int,int>> getRoomAvailable()
		{

			return _context.Phong
				 .GroupJoin(
					_context.Phong.Where(p => p.Status == "Trống"),
					lp => lp.RoomTypeID,
					p => p.RoomTypeID,
					(lp, rooms) => new Tuple<int, int>(lp.RoomTypeID, rooms.Count()))
					.Distinct()
					.ToList();
		}

		public int getRoomIDByRoomNumber(string roomNumber)
		{
			return _context.Phong.FirstOrDefault(p => p.RoomNumber == roomNumber).RoomID;
		}

		public void Update(Phong phong)
		{
			_context.Phong.Update(phong);
		}


	}
}
