using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day01G03.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MngId",
                schema: "dbo",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MngId",
                schema: "dbo",
                table: "Departments",
                column: "MngId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_MngId",
                schema: "dbo",
                table: "Departments",
                column: "MngId",
                principalSchema: "dbo",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_MngId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_MngId",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "MngId",
                schema: "dbo",
                table: "Departments");
        }
    }
}
