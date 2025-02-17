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
	public class LoaiPhongRepository : Repository<LoaiPhong>, ILoaiPhongRepository
	{
		private readonly ApplicationDbContext _context;
		public LoaiPhongRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(LoaiPhong loaiPhong)
		{
			_context.LoaiPhong.Update(loaiPhong);
		}

		public List<string> getListRoomType()
		{
			return _context.LoaiPhong.Select(p => p.RoomTypeName).ToList();
		}

		public int getRoomTypeID(string roomTypeName)
		{
			return _context.LoaiPhong.Where(p => p.RoomTypeName == roomTypeName).Select(p => p.RoomTypeID).FirstOrDefault();
		}

		public string getRoomTypeName(int roomTypeID)
		{
			return _context.LoaiPhong.Where(p => p.RoomTypeID == roomTypeID).Select(p => p.RoomTypeName).FirstOrDefault();
		}
	}
}
