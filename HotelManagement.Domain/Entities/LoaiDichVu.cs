using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Entities
{
	public class LoaiDichVu
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RoomServiceID { get; set; }
		public string RoomServiceName { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
	}
}
