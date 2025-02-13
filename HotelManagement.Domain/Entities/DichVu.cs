using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Entities
{
	public class DichVu
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ServiceID { get; set; }
		[ForeignKey("DatPhong")]
		public int BookingID { get; set; }
		public virtual DatPhong DatPhong { get; set; }

		[ForeignKey("LoaiDichVu")]
		public int RoomServiceID { get; set; }
		public virtual LoaiDichVu LoaiDichVu { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
