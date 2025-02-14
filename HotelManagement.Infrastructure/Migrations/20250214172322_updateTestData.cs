using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "Description",
                value: "Quản lý toàn bộ hệ thống.");

            migrationBuilder.UpdateData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "Description",
                value: "Quản lý dữ liệu và thực hiện các nghiệp vụ.");

            migrationBuilder.UpdateData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "Description",
                value: "Truy cập và sử dụng dịch vụ cơ bản.");

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "AccountID", "Address", "CreatedDate", "Email", "FirstName", "Gender", "LastName", "Password", "Phone", "RoleID", "Status", "UserName" },
                values: new object[,]
                {
                    { 5, "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh", new DateTime(2024, 4, 21, 7, 15, 55, 0, DateTimeKind.Unspecified), "khachhang2@example.com", "D", "Nữ", "Nguyễn Thị", "password123", "0987654323", 4, "Tạm Dừng", "Nguyễn Thị F" },
                    { 6, "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh", new DateTime(2024, 4, 21, 7, 15, 55, 0, DateTimeKind.Unspecified), "khachhang2@example.com", "D", "Nữ", "Nguyễn Thị", "password123", "0987654323", 5, "Tạm Dừng", "Nguyễn Thị G" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "Description",
                value: "Có quyền quản lý toàn bộ hệ thống.");

            migrationBuilder.UpdateData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "Description",
                value: "Có quyền quản lý dữ liệu và thực hiện các nghiệp vụ.");

            migrationBuilder.UpdateData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "Description",
                value: "Chỉ có quyền truy cập và sử dụng dịch vụ cơ bản.");
        }
    }
}
