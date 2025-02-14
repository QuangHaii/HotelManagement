using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Entities
{
	public class TaiKhoan
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AccountID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }
		public DateTime CreatedDate { get; set; }
		[ForeignKey("PhanQuyen")]
		public int RoleID { get; set; }
		public virtual PhanQuyen PhanQuyen { get; set; }
	}
}
