using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Entities
{
	public class DatPhong
	{
		[Key]
		public int BookingID { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public string BookingStatus { get; set; }
		public DateTime CreatedDate { get; set; }
		[ForeignKey("Phong")]
		public int RoomID { get; set; }
		public virtual Phong Phong { get; set; }
		[ForeignKey("TaiKhoan")]
		public int CustomerID { get; set; }
		public virtual TaiKhoan TaiKhoan { get; set; }
	}
}
