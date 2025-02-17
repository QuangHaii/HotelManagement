using HotelManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Application.Interfaces
{
	public interface ILoaiPhongRepository : IRepository<LoaiPhong>
	{
		void Update(LoaiPhong loaiPhong);
		List<string> getListRoomType();
		int getRoomTypeID(string roomTypeName);
		string getRoomTypeName(int roomTypeID);
	}
}
