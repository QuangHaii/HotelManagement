using HotelManagement.Application.Interfaces;
using HotelManagement.Domain.Entities;
using HotelManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Repository
{
	public class PhongRepository : Repository<Phong>, IPhongRepository
	{
		private readonly ApplicationDbContext _context;
		public PhongRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
		public void Update(Phong phong)
		{
			_context.Phong.Update(phong);
		}
	}
}
