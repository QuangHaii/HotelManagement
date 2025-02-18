using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Presentation.DTO
{
	public class BookingDTO
	{
		public int BookingID { get; set; }
		public string TênKháchHàng { get; set; }
		public string SốPhòng { get; set; }
		public string LoạiPhòng { get; set; }
		public DateTime NgàyNhậnPhòng { get; set; }
		public DateTime NgàyTrảPhòng { get; set; }
		public string TrạngThái { get; set; }
		public DateTime NgàyTạo { get; set; }
	}
}
