using HotelManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Interfaces
{
	public interface IPhanQuyenRepository : IRepository<PhanQuyen>
	{
		void Update(PhanQuyen phanQuyen);
		int FindRoleID(string roleName);
		string FindRoleName(int roleID);
		List<string> GetAllRoles();
		List<string> GetEmployeeRoles();
	}
}
