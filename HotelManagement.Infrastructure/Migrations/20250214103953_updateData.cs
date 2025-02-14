using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "UserName",
                value: "Nguyễn Văn A");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "UserName",
                value: "Trần Thị B");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "UserName",
                value: "Nguyễn Thị C");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "UserName",
                value: "Nguyễn Thị D");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "UserName",
                value: "admin123");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "UserName",
                value: "nhanvien01");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "UserName",
                value: "khachhang01");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "UserName",
                value: "khachhang02");
        }
    }
}
