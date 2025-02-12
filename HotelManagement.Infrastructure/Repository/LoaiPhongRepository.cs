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
	}
}
