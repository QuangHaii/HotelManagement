using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "RoomID",
                keyValue: 102,
                column: "Status",
                value: "Đã đặt");

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "RoomID",
                keyValue: 103,
                column: "Status",
                value: "Đã đặt");

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "RoomID",
                keyValue: 104,
                column: "Status",
                value: "Đã nhận");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "RoomID",
                keyValue: 102,
                column: "Status",
                value: "Đang sử dụng");

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "RoomID",
                keyValue: 103,
                column: "Status",
                value: "Bảo trì");

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "RoomID",
                keyValue: 104,
                column: "Status",
                value: "Đang sử dụng");
        }
    }
}
