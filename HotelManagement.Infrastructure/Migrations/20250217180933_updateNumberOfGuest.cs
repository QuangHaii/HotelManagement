using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateNumberOfGuest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfGuest",
                table: "DatPhong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "NumberOfGuest",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "NumberOfGuest",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 3,
                column: "NumberOfGuest",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfGuest",
                table: "DatPhong");
        }
    }
}
