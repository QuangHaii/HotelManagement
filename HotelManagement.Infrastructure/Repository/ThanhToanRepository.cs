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
	public class ThanhToanRepository : Repository<ThanhToan>, IThanhToanRepository
	{
		private readonly ApplicationDbContext _context;
		public ThanhToanRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(ThanhToan ThanhToan)
		{
			_context.ThanhToan.Update(ThanhToan);
		}
	}
}
