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
		public void Update(DichVu dichVu)
		{
			_context.DichVu.Update(dichVu);
		}
	}
}
