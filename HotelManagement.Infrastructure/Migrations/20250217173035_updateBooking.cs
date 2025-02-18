using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "BookingStatus",
                value: "Hoàn thành");

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "BookingStatus",
                value: "Đã đặt");

            migrationBuilder.InsertData(
                table: "DatPhong",
                columns: new[] { "BookingID", "BookingStatus", "CheckInDate", "CheckOutDate", "CreatedDate", "CustomerID", "RoomID" },
                values: new object[] { 3, "Đã đặt", new DateTime(2023, 6, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, 104 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "BookingStatus",
                value: "Completed");

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "BookingStatus",
                value: "Ongoing");
        }
    }
}
