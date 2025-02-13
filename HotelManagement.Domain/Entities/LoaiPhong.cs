using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Entities
{
	public class LoaiPhong
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RoomTypeID { get; set; }
		public string RoomTypeName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Capacity { get; set; }
	}
}
