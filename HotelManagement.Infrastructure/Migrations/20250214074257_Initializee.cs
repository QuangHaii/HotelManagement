using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initializee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "TaiKhoan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "TaiKhoan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 1,
                columns: new[] { "Address", "Gender" },
                values: new object[] { "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh", "Nam" });

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 2,
                columns: new[] { "Address", "Gender" },
                values: new object[] { "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh", "Nữ" });

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 3,
                columns: new[] { "Address", "Gender" },
                values: new object[] { "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh", "Nam" });

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 4,
                columns: new[] { "Address", "Gender" },
                values: new object[] { "123 Đường ABC, Quận XYZ, TP. Hồ Chí Minh", "Nữ" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "TaiKhoan");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TaiKhoan");
        }
    }
}
