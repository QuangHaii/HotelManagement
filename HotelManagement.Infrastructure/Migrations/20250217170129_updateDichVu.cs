using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateDichVu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DichVu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "ServiceID",
                keyValue: 1,
                column: "Description",
                value: "Hello World!222");

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "ServiceID",
                keyValue: 2,
                column: "Description",
                value: "Hello World!111");

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "ServiceID",
                keyValue: 3,
                column: "Description",
                value: "Hello World!123");

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "ServiceID",
                keyValue: 4,
                column: "Description",
                value: "Hello World!456");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "DichVu");
        }
    }
}
