using HotelManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Interfaces
{
	public interface IDatPhongRepository : IRepository<DatPhong>
	{
		void Update(DatPhong datPhong);
		bool CheckBookingIDExist(int bookingID);
		string getCustomerName(int bookingID);
	}
}
