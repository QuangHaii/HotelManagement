using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatePaymentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 1,
                column: "PaymentStatus",
                value: "Thành công!");

            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 2,
                column: "PaymentStatus",
                value: "Chưa thanh toán");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 1,
                column: "PaymentStatus",
                value: "Successful");

            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 2,
                column: "PaymentStatus",
                value: "Pending");
        }
    }
}
