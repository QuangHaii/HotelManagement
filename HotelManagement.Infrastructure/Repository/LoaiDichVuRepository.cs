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
	public class LoaiDichVuRepository : Repository<LoaiDichVu>, ILoaiDichVuRepository
	{
		private readonly ApplicationDbContext _context;
		public LoaiDichVuRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public int GetServiceTypeID(string name)
		{
			return _context.LoaiDichVu.Where(x => x.RoomServiceName == name).Select(x => x.RoomServiceID).FirstOrDefault();
		}

		public void Update(LoaiDichVu loaiDichVu)
		{
			_context.LoaiDichVu.Update(loaiDichVu);
		}
	}
}
