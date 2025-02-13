using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Entities
{
	public class ThanhToan
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PaymentID { get; set; }
		public decimal Total { get; set; }
		public DateTime PaymentDate { get; set; }
		public string PaymentMethod { get; set; }
		public string PaymentStatus { get; set; }
		public string Description { get; set; }
		[ForeignKey("DatPhong")]
		public int BookingID { get; set; }
		public virtual DatPhong DatPhong { get; set; }
	}
}
