using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "TaiKhoan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "PhanQuyen",
                columns: new[] { "RoleID", "Description", "RoleName" },
                values: new object[,]
                {
                    { 4, "Đón tiếp, hướng dẫn, trả lời câu hỏi của khách hàng.", "Lễ tân" },
                    { 5, "Đảm bảo an ninh và bảo vệ tài sản.", "Bảo vệ" }
                });

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "Status",
                value: "Hoạt động");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "Status",
                value: "Hoạt động");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "Status",
                value: "Tạm Dừng");

            migrationBuilder.UpdateData(
                table: "TaiKhoan",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "Status",
                value: "Tạm Dừng");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PhanQuyen",
                keyColumn: "RoleID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TaiKhoan");
        }
    }
}
