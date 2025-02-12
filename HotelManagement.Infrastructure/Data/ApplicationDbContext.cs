using HotelManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<TaiKhoan> TaiKhoan { get; set; }
		public DbSet<PhanQuyen> PhanQuyen { get; set; }
		public DbSet<Phong> Phong { get; set; }
		public DbSet<DatPhong> DatPhong { get; set; }
		public DbSet<LoaiPhong> LoaiPhong { get; set; }
		public DbSet<DichVu> DichVu { get; set; }
		public DbSet<LoaiDichVu> LoaiDichVu { get; set; }
		public DbSet<ThanhToan> ThanhToan { get; set; }

		public ApplicationDbContext()
		{
		}
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString = "Server=HINOBY\\SQLEXPRESS;Database=HotelManagement;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
			optionsBuilder.UseSqlServer(connectionString);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PhanQuyen>().HasData(
				new PhanQuyen {
					RoleID = 1,
					RoleName = "Quản trị viên",
					Description = "Có quyền quản lý toàn bộ hệ thống."
				},
				new PhanQuyen {
					RoleID = 2,
					RoleName = "Nhân viên",
					Description = "Có quyền quản lý dữ liệu và thực hiện các nghiệp vụ."
				},
				new PhanQuyen {
					RoleID = 3,
					RoleName = "Khách hàng",
					Description = "Chỉ có quyền truy cập và sử dụng dịch vụ cơ bản."
				}
			);

			modelBuilder.Entity<TaiKhoan>().HasData(
				new TaiKhoan
				{
					AccountID = 1,
					UserName = "admin123",
					Password = "admin@123",
					FirstName = "Nguyễn",
					LastName = "Văn A",
					Email = "admin@example.com",
					Phone = "0123456789",
					CreatedDate = new DateTime(2024, 1, 15, 14, 32, 45),
					RoleID = 1,
				},
				new TaiKhoan
				{
					AccountID = 2,
					UserName = "nhanvien01",
					Password = "password123",
					FirstName = "Trần",
					LastName = "Thị B",
					Email = "nhanvien@example.com",
					Phone = "0987654321",
					CreatedDate = new DateTime(2023, 6, 7, 9, 20, 10),
					RoleID = 2
				},
				new TaiKhoan
				{
					AccountID = 3,
					UserName = "khachhang01",
					Password = "password123",
					FirstName = "Nguyễn",
					LastName = "Thị C",
					Email = "khachhang@example.com",
					Phone = "0987654320",
					CreatedDate = new DateTime(2025, 11, 2, 18, 50, 30),
					RoleID = 3
				},
				new TaiKhoan
				{
					AccountID = 4,
					UserName = "khachhang02",
					Password = "password123",
					FirstName = "Nguyễn",
					LastName = "Thị D",
					Email = "khachhang@example.com",
					Phone = "0987654323",
					CreatedDate = new DateTime(2024, 4, 21, 7, 15, 55),
					RoleID = 3
				}
			);

			modelBuilder.Entity<LoaiPhong>().HasData(
				new LoaiPhong {
					RoomTypeID = 101,
					RoomTypeName = "Phòng Đơn Cao Cấp",
					Description = "Phòng đơn rộng rãi với tiện nghi cao cấp.",
					Price = 200.50m,
					Capacity = 1
				},
				new LoaiPhong {
					RoomTypeID = 102,
					RoomTypeName = "Phòng Gia Đình",
					Description = "Phòng dành cho gia đình với hai giường lớn.",
					Price = 350.75m,
					Capacity = 4
				},
				new LoaiPhong
				{
					RoomTypeID = 103,
					RoomTypeName = "Phòng Tổng Thống",
					Description = "Phòng suite sang trọng với dịch vụ cao cấp.",
					Price = 500.00m,
					Capacity = 6
				}
			);

			modelBuilder.Entity<Phong>().HasData(
				new Phong
				{
					RoomID = 101,
					RoomNumber = "A101",
					Floor = 1,
					Status = "Trống",
					RoomTypeID = 101,
				},
				new Phong
				{
					RoomID = 102,
					RoomNumber = "B202",
					Floor = 2,
					Status = "Đang sử dụng",
					RoomTypeID = 102,
				},
				new Phong
				{
					RoomID = 103,
					RoomNumber = "C303",
					Floor = 3,
					Status = "Bảo trì",
					RoomTypeID = 101,
				},
				new Phong
				{
					RoomID = 104,
					RoomNumber = "D404",
					Floor = 4,
					Status = "Đang sử dụng",
					RoomTypeID = 103,
				}
				);

			modelBuilder.Entity<LoaiDichVu>().HasData(
				new LoaiDichVu {
					RoomServiceID = 1,
					RoomServiceName = "Dọn phòng hàng ngày",
					Price = 50.00m,
					Description = "Dịch vụ dọn dẹp và làm sạch phòng mỗi ngày."
				},
				new LoaiDichVu {
					RoomServiceID = 2,
					RoomServiceName = "Giặt là",
					Price = 100.00m,
					Description = "Dịch vụ giặt ủi quần áo trong ngày."
				},
				new LoaiDichVu {
					RoomServiceID = 3,
					RoomServiceName = "Đưa đón sân bay",
					Price = 150.00m,
					Description = "Dịch vụ đưa đón từ sân bay đến khách sạn và ngược lại."
				}
			);

			modelBuilder.Entity<DatPhong>().HasData(
				new DatPhong
				{
					BookingID = 1,
					// Check-in: Jan 15, 2024 | Check-out: Jan 18, 2024
					CheckInDate = new DateTime(2024, 1, 15, 14, 30, 0),
					CheckOutDate = new DateTime(2024, 1, 18, 11, 0, 0),
					BookingStatus = "Completed",
					CreatedDate = new DateTime(2024, 1, 14, 14, 30, 0),
					RoomID = 102,
					CustomerID = 3
				},
				new DatPhong
				{
					BookingID = 2,
					// Check-in: June 7, 2023 | Check-out: June 10, 2023
					CheckInDate = new DateTime(2023, 6, 7, 16, 0, 0),
					CheckOutDate = new DateTime(2023, 6, 10, 10, 0, 0),
					BookingStatus = "Ongoing",
					CreatedDate = new DateTime(2023, 6, 6, 16, 0, 0),
					RoomID = 103,
					CustomerID = 4
				}
			);

			modelBuilder.Entity<DichVu>().HasData(
				new DichVu
				{
					ServiceID = 1,
					BookingID = 1,
					RoomServiceID = 1,
					CreatedDate = new DateTime(2024, 1, 15, 14, 30, 0)
				},
				new DichVu
				{
					ServiceID = 2,
					BookingID = 1,
					RoomServiceID = 2,
					CreatedDate = new DateTime(2024, 1, 15, 14, 30, 0)
				},
				new DichVu
				{
					ServiceID = 3,
					BookingID = 2,
					RoomServiceID = 1,
					CreatedDate = new DateTime(2023, 6, 7, 16, 0, 0)
				},
				new DichVu
				{
					ServiceID = 4,
					BookingID = 2,
					RoomServiceID = 3,
					CreatedDate = new DateTime(2023, 6, 7, 16, 0, 0)
				}
			);

			modelBuilder.Entity<ThanhToan>().HasData(
				 new ThanhToan
				 {
					 PaymentID = 1,
					 Total = 2_000_000m,
					 PaymentDate = new DateTime(2024, 1, 18, 11, 0, 0),
					 PaymentMethod = "Credit Card",
					 PaymentStatus = "Successful",
					 Description = "Thanh toán qua thẻ tín dụng",
					 BookingID = 1
				 },
				new ThanhToan
				{
					PaymentID = 2,
					Total = 1_500_000m,
					PaymentDate = new DateTime(2023, 6, 10, 10, 0, 0),
					PaymentMethod = "Cash",
					PaymentStatus = "Pending",
					Description = "Thanh toán tiền mặt khi trả phòng",
					BookingID = 2
				}
			);
		}
	}
}
