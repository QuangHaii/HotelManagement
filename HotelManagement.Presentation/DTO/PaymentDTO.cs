using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Presentation.DTO
{
	public class PaymentDTO
	{
		public int IDThanhToán { get; set; }
		public int IDBooking { get; set; }
		public string TênKháchHàng { get; set; }
		public decimal TổngTiền { get; set; }
		public string PhươngThức { get; set; }
		public DateTime NgàyThanhToán { get; set; }
		public string TrạngThái { get; set; }
		public string GhiChú { get; set; }
	}
}
