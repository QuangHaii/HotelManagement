using HotelManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Interfaces
{
	public interface IPhongRepository : IRepository<Phong>
	{
		void Update(Phong phong);
		List<Tuple<int, int>> getRoomAvailable();

		List<string> getListRoomNameByRoomType(int roomTypeID);
		int getRoomIDByRoomNumber(string roomNumber);
		decimal getPriceByBookingID(int bookingID);
	}
}
