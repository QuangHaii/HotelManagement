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
	public class PhanQuyenRepository : Repository<PhanQuyen>, IPhanQuyenRepository
	{
		private readonly ApplicationDbContext _context;
		public PhanQuyenRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(PhanQuyen phanQuyen)
		{
			_context.PhanQuyen.Update(phanQuyen);
		}
		public int FindRoleID(string roleName)
		{
			return _context.PhanQuyen.FirstOrDefault(x => x.RoleName == roleName).RoleID;
		}
		public List<string> GetAllRoles()
		{
			return _context.PhanQuyen.Select(x => x.RoleName).ToList();
		}

		public List<string> GetEmployeeRoles()
		{
			return _context.PhanQuyen
					.Where(x => x.RoleID != 3 && x.RoleID != 1) 
					.Select(x => x.RoleName)
					.ToList();
		}

		public string FindRoleName(int roleID)
		{
			return _context.PhanQuyen.FirstOrDefault(x => x.RoleID == roleID).RoleName;
		}
	}
}
