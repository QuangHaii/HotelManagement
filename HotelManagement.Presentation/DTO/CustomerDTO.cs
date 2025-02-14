using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Presentation.DTO
{
	public class CustomerDTO
	{
		public int ID { get; set; }
		public string TênKháchHàng { get; set; }
		public string TênĐệm { get; set; }
		public string HọVàTên { get;set; }
		public string GiớiTính { get; set; }
		public string SốĐiệnThoại { get; set; }
		public string Email { get; set; }
		public string ĐịaChỉ { get; set; }
	}
}
