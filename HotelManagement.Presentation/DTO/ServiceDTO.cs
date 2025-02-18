using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Presentation.DTO
{
	public class ServiceDTO
	{
		public int IDĐơnDịchVụ { get; set; }
		public int BookingID { get; set; }
		public int IDLoạiDịchVụ { get; set; }
		public string TênDịchVụ { get; set; }
		public DateTime NgàyTạo { get; set; }
		public string MôTả { get; set; }
	}
}
