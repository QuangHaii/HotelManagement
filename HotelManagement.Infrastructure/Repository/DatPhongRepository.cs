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
	}
}
