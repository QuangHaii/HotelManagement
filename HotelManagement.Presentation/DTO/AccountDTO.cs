using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Presentation.DTO
{
	public class AccountDTO
	{
		public int ID { get; set; }
		public string HọVàTên { get; set; }
		public string GiớiTính { get; set; }
		public string SốĐiệnThoại { get; set; }
		public string Email { get; set; }
		public string ĐịaChỉ { get; set; }
		public string PhânQuyền { get; set; }
		public DateTime NgàyTạo { get; set; }
		public string TrạngThái { get; set; }
	}
}
