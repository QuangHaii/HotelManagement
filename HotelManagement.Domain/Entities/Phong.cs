using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Entities
{
	public class Phong
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RoomID { get; set; }
		public string RoomNumber { get; set; }
		public int Floor { get; set; }
		public string Status { get; set; }
		[ForeignKey("LoaiPhong")]
		public int RoomTypeID { get; set; }
		public virtual LoaiPhong LoaiPhong { get; set; }
	}
}
