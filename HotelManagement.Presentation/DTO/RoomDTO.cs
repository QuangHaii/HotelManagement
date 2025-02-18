using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Presentation.DTO
{
	public class RoomDTO
	{
		public int IDPhòng { get; set; }
		public int IDLoạiPhòng { get; set; }
		public string SốPhòng { get; set; }
		public int SốTầng { get; set; }
		public string TrạngThái { get; set; }
		public string LoạiPhòng { get; set; }
		public int SốLượngNgười { get; set; }
		public string Giá { get; set; }
		public string MôTả { get; set; }
	}
}
