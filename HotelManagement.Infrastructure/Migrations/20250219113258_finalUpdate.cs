using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class finalUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 1,
                columns: new[] { "PaymentMethod", "PaymentStatus" },
                values: new object[] { "Chuyển khoản", "Đã thanh toán" });

            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 2,
                column: "PaymentMethod",
                value: "Tiền mặt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 1,
                columns: new[] { "PaymentMethod", "PaymentStatus" },
                values: new object[] { "Credit Card", "Thành công!" });

            migrationBuilder.UpdateData(
                table: "ThanhToan",
                keyColumn: "PaymentID",
                keyValue: 2,
                column: "PaymentMethod",
                value: "Cash");
        }
    }
}
