using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day01G03.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneMMRealationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_City",
                schema: "dbo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Country",
                schema: "dbo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Street",
                schema: "dbo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpAddress_City",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Country",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Street",
                schema: "dbo",
                table: "Employees");
        }
    }
}
