using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day01G03.Migrations
{
    /// <inheritdoc />
    public partial class RenameEmpId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpId",
                schema: "dbo",
                table: "Employees",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Employees",
                newName: "EmpId");
        }
    }
}
