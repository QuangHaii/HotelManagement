﻿// <auto-generated />
using System;
using HotelManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250219113258_finalUpdate")]
    partial class finalUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelManagement.Domain.Entities.DatPhong", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<string>("BookingStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuest")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("RoomID");

                    b.ToTable("DatPhong");

                    b.HasData(
                        new
                        {
                            BookingID = 1,
                            BookingStatus = "Hoàn thành",
                            CheckInDate = new DateTime(2024, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            CheckOutDate = new DateTime(2024, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2024, 1, 14, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            CustomerID = 3,
                            NumberOfGuest = 1,
                            RoomID = 102
                        },
                        new
                        {
                            BookingID = 2,
                            BookingStatus = "Đã đặt",
                            CheckInDate = new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOutDate = new DateTime(2023, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerID = 4,
                            NumberOfGuest = 2,
                            RoomID = 103
                        },
                        new
                        {
                            BookingID = 3,
                            BookingStatus = "Đã đặt",
                            CheckInDate = new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOutDate = new DateTime(2023, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerID = 5,
                            NumberOfGuest = 3,
                            RoomID = 104
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.DichVu", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomServiceID")
                        .HasColumnType("int");

                    b.HasKey("ServiceID");

                    b.HasIndex("BookingID");

                    b.HasIndex("RoomServiceID");

                    b.ToTable("DichVu");

                    b.HasData(
                        new
                        {
                            ServiceID = 1,
                            BookingID = 1,
                            CreatedDate = new DateTime(2024, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hello World!222",
                            RoomServiceID = 1
                        },
                        new
                        {
                            ServiceID = 2,
                            BookingID = 1,
                            CreatedDate = new DateTime(2024, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hello World!111",
                            RoomServiceID = 2
                        },
                        new
                        {
                            ServiceID = 3,
                            BookingID = 2,
                            CreatedDate = new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hello World!123",
                            RoomServiceID = 1
                        },
                        new
                        {
                            ServiceID = 4,
                            BookingID = 2,
                            CreatedDate = new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hello World!456",
                            RoomServiceID = 3
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.LoaiDichVu", b =>
                {
                    b.Property<int>("RoomServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomServiceID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomServiceID");

                    b.ToTable("LoaiDichVu");

                    b.HasData(
                        new
                        {
                            RoomServiceID = 1,
                            Description = "Dịch vụ dọn dẹp và làm sạch phòng mỗi ngày.",
                            Price = 50.00m,
                            RoomServiceName = "Dọn phòng hàng ngày"
                        },
                        new
                        {
                            RoomServiceID = 2,
                            Description = "Dịch vụ giặt ủi quần áo trong ngày.",
                            Price = 100.00m,
                            RoomServiceName = "Giặt là"
                        },
                        new
                        {
                            RoomServiceID = 3,
                            Description = "Dịch vụ đưa đón từ sân bay đến khách sạn và ngược lại.",
                            Price = 150.00m,
                            RoomServiceName = "Đưa đón sân bay"
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.LoaiPhong", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeID"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoomTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeID");

                    b.ToTable("LoaiPhong");

                    b.HasData(
                        new
                        {
                            RoomTypeID = 101,
                            Capacity = 1,
                            Description = "Phòng đơn rộng rãi với tiện nghi cao cấp.",
                            Price = 200.50m,
                            RoomTypeName = "Phòng Đơn Cao Cấp"
                        },
                        new
                        {
                            RoomTypeID = 102,
                            Capacity = 4,
                            Description = "Phòng dành cho gia đình với hai giường lớn.",
                            Price = 350.75m,
                            RoomTypeName = "Phòng Gia Đình"
                        },
                        new
                        {
                            RoomTypeID = 103,
                            Capacity = 6,
                            Description = "Phòng suite sang trọng với dịch vụ cao cấp.",
                            Price = 500.00m,
                            RoomTypeName = "Phòng Tổng Thống"
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.PhanQuyen", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("PhanQuyen");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Description = "Quản lý toàn bộ hệ thống.",
                            RoleName = "Quản trị viên"
                        },
                        new
                        {
                            RoleID = 2,
                            Description = "Quản lý dữ liệu và thực hiện các nghiệp vụ.",
                            RoleName = "Nhân viên"
                        },
                        new
                        {
                            RoleID = 3,
                            Description = "Truy cập và sử dụng dịch vụ cơ bản.",
                            RoleName = "Khách hàng"
                        },
                        new
                        {
                            RoleID = 4,
                            Description = "Đón tiếp, hướng dẫn, trả lời câu hỏi của khách hàng.",
                            RoleName = "Lễ tân"
                        },
                        new
                        {
                            RoleID = 5,
                            Description = "Đảm bảo an ninh và bảo vệ tài sản.",
                            RoleName = "Bảo vệ"
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.Phong", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Phong");

                    b.HasData(
                        new
                        {
                            RoomID = 101,
                            Floor = 1,
                            RoomNumber = "A101",
                            RoomTypeID = 101,
                            Status = "Trống"
                        },
                        new
                        {
                            RoomID = 102,
                            Floor = 2,
                            RoomNumber = "B202",
                            RoomTypeID = 102,
                            Status = "Đã đặt"
                        },
                        new
                        {
                            RoomID = 103,
                            Floor = 3,
                            RoomNumber = "C303",
                            RoomTypeID = 101,
                            Status = "Đã đặt"
                        },
                        new
                        {
                            RoomID = 104,
                            Floor = 4,
                            RoomNumber = "D404",
                            RoomTypeID = 103,
                            Status = "Đã nhận"
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.TaiKhoan", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.HasIndex("RoleID");

                    b.ToTable("TaiKhoan");

                    b.HasData(
                        new
                        {
                            AccountID = 1,
                            Address = "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh",
                            CreatedDate = new DateTime(2024, 1, 15, 14, 32, 45, 0, DateTimeKind.Unspecified),
                            Email = "admin@example.com",
                            FirstName = "A",
                            Gender = "Nam",
                            LastName = "Nguyễn Văn",
                            Password = "admin@123",
                            Phone = "0123456789",
                            RoleID = 1,
                            Status = "Hoạt động",
                            UserName = "Nguyễn Văn A"
                        },
                        new
                        {
                            AccountID = 2,
                            Address = "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh",
                            CreatedDate = new DateTime(2023, 6, 7, 9, 20, 10, 0, DateTimeKind.Unspecified),
                            Email = "nhanvien1@example.com",
                            FirstName = "B",
                            Gender = "Nữ",
                            LastName = "Trần Thị",
                            Password = "password123",
                            Phone = "0987654321",
                            RoleID = 2,
                            Status = "Hoạt động",
                            UserName = "Trần Thị B"
                        },
                        new
                        {
                            AccountID = 3,
                            Address = "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh",
                            CreatedDate = new DateTime(2025, 11, 2, 18, 50, 30, 0, DateTimeKind.Unspecified),
                            Email = "khachhang1@example.com",
                            FirstName = "C",
                            Gender = "Nam",
                            LastName = "Nguyễn Thị",
                            Password = "password123",
                            Phone = "0987654320",
                            RoleID = 3,
                            Status = "Tạm Dừng",
                            UserName = "Nguyễn Thị C"
                        },
                        new
                        {
                            AccountID = 4,
                            Address = "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh",
                            CreatedDate = new DateTime(2024, 4, 21, 7, 15, 55, 0, DateTimeKind.Unspecified),
                            Email = "khachhang2@example.com",
                            FirstName = "D",
                            Gender = "Nữ",
                            LastName = "Nguyễn Thị",
                            Password = "password123",
                            Phone = "0987654323",
                            RoleID = 3,
                            Status = "Tạm Dừng",
                            UserName = "Nguyễn Thị D"
                        },
                        new
                        {
                            AccountID = 5,
                            Address = "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh",
                            CreatedDate = new DateTime(2024, 4, 21, 7, 15, 55, 0, DateTimeKind.Unspecified),
                            Email = "khachhang2@example.com",
                            FirstName = "D",
                            Gender = "Nữ",
                            LastName = "Nguyễn Thị",
                            Password = "password123",
                            Phone = "0987654323",
                            RoleID = 4,
                            Status = "Tạm Dừng",
                            UserName = "Nguyễn Thị F"
                        },
                        new
                        {
                            AccountID = 6,
                            Address = "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh",
                            CreatedDate = new DateTime(2024, 4, 21, 7, 15, 55, 0, DateTimeKind.Unspecified),
                            Email = "khachhang2@example.com",
                            FirstName = "D",
                            Gender = "Nữ",
                            LastName = "Nguyễn Thị",
                            Password = "password123",
                            Phone = "0987654323",
                            RoleID = 5,
                            Status = "Tạm Dừng",
                            UserName = "Nguyễn Thị G"
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.ThanhToan", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PaymentID");

                    b.HasIndex("BookingID");

                    b.ToTable("ThanhToan");

                    b.HasData(
                        new
                        {
                            PaymentID = 1,
                            BookingID = 1,
                            Description = "Thanh toán qua thẻ tín dụng",
                            PaymentDate = new DateTime(2024, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentMethod = "Chuyển khoản",
                            PaymentStatus = "Đã thanh toán",
                            Total = 2000000m
                        },
                        new
                        {
                            PaymentID = 2,
                            BookingID = 2,
                            Description = "Thanh toán tiền mặt khi trả phòng",
                            PaymentDate = new DateTime(2023, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentMethod = "Tiền mặt",
                            PaymentStatus = "Chưa thanh toán",
                            Total = 1500000m
                        });
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.DatPhong", b =>
                {
                    b.HasOne("HotelManagement.Domain.Entities.TaiKhoan", "TaiKhoan")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagement.Domain.Entities.Phong", "Phong")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phong");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.DichVu", b =>
                {
                    b.HasOne("HotelManagement.Domain.Entities.DatPhong", "DatPhong")
                        .WithMany()
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagement.Domain.Entities.LoaiDichVu", "LoaiDichVu")
                        .WithMany()
                        .HasForeignKey("RoomServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DatPhong");

                    b.Navigation("LoaiDichVu");
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.Phong", b =>
                {
                    b.HasOne("HotelManagement.Domain.Entities.LoaiPhong", "LoaiPhong")
                        .WithMany()
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.TaiKhoan", b =>
                {
                    b.HasOne("HotelManagement.Domain.Entities.PhanQuyen", "PhanQuyen")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhanQuyen");
                });

            modelBuilder.Entity("HotelManagement.Domain.Entities.ThanhToan", b =>
                {
                    b.HasOne("HotelManagement.Domain.Entities.DatPhong", "DatPhong")
                        .WithMany()
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DatPhong");
                });
#pragma warning restore 612, 618
        }
    }
}
