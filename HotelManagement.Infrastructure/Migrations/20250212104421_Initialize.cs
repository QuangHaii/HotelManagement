using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiDichVu",
                columns: table => new
                {
                    RoomServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDichVu", x => x.RoomServiceID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    RoomTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.RoomTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PhanQuyen",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanQuyen", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Phong_LoaiPhong_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "LoaiPhong",
                        principalColumn: "RoomTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_PhanQuyen_RoleID",
                        column: x => x.RoleID,
                        principalTable: "PhanQuyen",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatPhong",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatPhong", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_DatPhong_Phong_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Phong",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatPhong_TaiKhoan_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "TaiKhoan",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingID = table.Column<int>(type: "int", nullable: false),
                    RoomServiceID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_DichVu_DatPhong_BookingID",
                        column: x => x.BookingID,
                        principalTable: "DatPhong",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DichVu_LoaiDichVu_RoomServiceID",
                        column: x => x.RoomServiceID,
                        principalTable: "LoaiDichVu",
                        principalColumn: "RoomServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_ThanhToan_DatPhong_BookingID",
                        column: x => x.BookingID,
                        principalTable: "DatPhong",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LoaiDichVu",
                columns: new[] { "RoomServiceID", "Description", "Price", "RoomServiceName" },
                values: new object[,]
                {
                    { 1, "Dịch vụ dọn dẹp và làm sạch phòng mỗi ngày.", 50.00m, "Dọn phòng hàng ngày" },
                    { 2, "Dịch vụ giặt ủi quần áo trong ngày.", 100.00m, "Giặt là" },
                    { 3, "Dịch vụ đưa đón từ sân bay đến khách sạn và ngược lại.", 150.00m, "Đưa đón sân bay" }
                });

            migrationBuilder.InsertData(
                table: "LoaiPhong",
                columns: new[] { "RoomTypeID", "Capacity", "Description", "Price", "RoomTypeName" },
                values: new object[,]
                {
                    { 101, 1, "Phòng đơn rộng rãi với tiện nghi cao cấp.", 200.50m, "Phòng Đơn Cao Cấp" },
                    { 102, 4, "Phòng dành cho gia đình với hai giường lớn.", 350.75m, "Phòng Gia Đình" },
                    { 103, 6, "Phòng suite sang trọng với dịch vụ cao cấp.", 500.00m, "Phòng Tổng Thống" }
                });

            migrationBuilder.InsertData(
                table: "PhanQuyen",
                columns: new[] { "RoleID", "Description", "RoleName" },
                values: new object[,]
                {
                    { 1, "Có quyền quản lý toàn bộ hệ thống.", "Quản trị viên" },
                    { 2, "Có quyền quản lý dữ liệu và thực hiện các nghiệp vụ.", "Nhân viên" },
                    { 3, "Chỉ có quyền truy cập và sử dụng dịch vụ cơ bản.", "Khách hàng" }
                });

            migrationBuilder.InsertData(
                table: "Phong",
                columns: new[] { "RoomID", "Floor", "RoomNumber", "RoomTypeID", "Status" },
                values: new object[,]
                {
                    { 101, 1, "A101", 101, "Trống" },
                    { 102, 2, "B202", 102, "Đang sử dụng" },
                    { 103, 3, "C303", 101, "Bảo trì" },
                    { 104, 4, "D404", 103, "Đang sử dụng" }
                });

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "AccountID", "CreatedDate", "Email", "FirstName", "LastName", "Password", "Phone", "RoleID", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 15, 14, 32, 45, 0, DateTimeKind.Unspecified), "admin@example.com", "Nguyễn", "Văn A", "admin@123", "0123456789", 1, "admin123" },
                    { 2, new DateTime(2023, 6, 7, 9, 20, 10, 0, DateTimeKind.Unspecified), "nhanvien@example.com", "Trần", "Thị B", "password123", "0987654321", 2, "nhanvien01" },
                    { 3, new DateTime(2025, 11, 2, 18, 50, 30, 0, DateTimeKind.Unspecified), "khachhang@example.com", "Nguyễn", "Thị C", "password123", "0987654320", 3, "khachhang01" },
                    { 4, new DateTime(2024, 4, 21, 7, 15, 55, 0, DateTimeKind.Unspecified), "khachhang@example.com", "Nguyễn", "Thị D", "password123", "0987654323", 3, "khachhang02" }
                });

            migrationBuilder.InsertData(
                table: "DatPhong",
                columns: new[] { "BookingID", "BookingStatus", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerID", "RoomID" },
                values: new object[,]
                {
                    { 1, "Completed", new DateTime(2024, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), 3, 102 },
                    { 2, "Ongoing", new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, 103 }
                });

            migrationBuilder.InsertData(
                table: "DichVu",
                columns: new[] { "ServiceID", "BookingID", "CreatedDate", "RoomServiceID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1, new DateTime(2024, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 2, new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 2, new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ThanhToan",
                columns: new[] { "PaymentID", "BookingID", "Description", "PaymentDate", "PaymentMethod", "PaymentStatus", "Total" },
                values: new object[,]
                {
                    { 1, 1, "Thanh toán qua thẻ tín dụng", new DateTime(2024, 1, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), "Credit Card", "Successful", 2000000m },
                    { 2, 2, "Thanh toán tiền mặt khi trả phòng", new DateTime(2023, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Cash", "Pending", 1500000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_CustomerID",
                table: "DatPhong",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_RoomID",
                table: "DatPhong",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_BookingID",
                table: "DichVu",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_DichVu_RoomServiceID",
                table: "DichVu",
                column: "RoomServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_RoomTypeID",
                table: "Phong",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_RoleID",
                table: "TaiKhoan",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_BookingID",
                table: "ThanhToan",
                column: "BookingID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropTable(
                name: "LoaiDichVu");

            migrationBuilder.DropTable(
                name: "DatPhong");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "PhanQuyen");
        }
    }
}
