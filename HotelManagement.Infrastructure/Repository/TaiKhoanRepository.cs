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

		public TaiKhoan FindByEmail(string email)
		{
			return _context.TaiKhoan.FirstOrDefault(x => x.Email == email);
		}

		public TaiKhoan FindByPhone(string phone)
		{
			return _context.TaiKhoan.FirstOrDefault(x => x.Phone == phone);
		}

		public List<TaiKhoan> GetAllCustomers()
		{
			return _context.TaiKhoan.Where(x => x.RoleID == 3).ToList();
		}

		public List<TaiKhoan> GetAllEmployees()
		{
			return _context.TaiKhoan.Where(x => x.RoleID != 3 && x.RoleID != 1).ToList();
		}

		public int getIDByName(string name)
		{
			return _context.TaiKhoan.FirstOrDefault(x => x.UserName == name).AccountID;
		}

		public bool checkCustomerExist(int ID)
		{
			return _context.TaiKhoan.Any(x => x.AccountID == ID && x.RoleID == 3);
		}
	}
}
