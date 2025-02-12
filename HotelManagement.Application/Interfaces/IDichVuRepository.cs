using HotelManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Interfaces
{
	public interface IDichVuRepository : IRepository<DichVu>
	{
		void Update(DichVu dichVu);
	}
}
