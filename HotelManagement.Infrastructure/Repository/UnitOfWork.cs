using HotelManagement.Application.Interfaces;
using HotelManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;
		public IDatPhongRepository DatPhongRepository { get; private set; }

		public ITaiKhoanRepository TaiKhoanRepository { get; private set; }

		public ILoaiPhongRepository LoaiPhongRepository { get; private set; }

		public IPhongRepository PhongRepository { get; private set; }

		public IThanhToanRepository ThanhToanRepository { get; private set; }

		public IPhanQuyenRepository PhanQuyenRepository { get; private set; }

		public ILoaiDichVuRepository LoaiDichVuRepository { get; private set; }

		public IDichVuRepository DichVuRepository { get; private set; }
		public UnitOfWork(ApplicationDbContext context)
		{
			_context = context;
			DatPhongRepository = new DatPhongRepository(_context);
			TaiKhoanRepository = new TaiKhoanRepository(_context);
			LoaiPhongRepository = new LoaiPhongRepository(_context);
			PhongRepository = new PhongRepository(_context);
			ThanhToanRepository = new ThanhToanRepository(_context);
			PhanQuyenRepository = new PhanQuyenRepository(_context);
			LoaiDichVuRepository = new LoaiDichVuRepository(_context);
			DichVuRepository = new DichVuRepository(_context);
		}
		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
