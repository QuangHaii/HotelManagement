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
	public class TaiKhoanRepository : Repository<TaiKhoan>, ITaiKhoanRepository
	{
		private readonly ApplicationDbContext _context;
		public TaiKhoanRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(TaiKhoan TaiKhoan)
		{
			_context.TaiKhoan.Update(TaiKhoan);
		}
	}
}
