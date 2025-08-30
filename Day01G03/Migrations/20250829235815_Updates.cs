using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day01G03.Migrations
{
    /// <inheritdoc />
    public partial class Updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfCreation",
                schema: "dbo",
                table: "Departments",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldComputedColumnSql: "GetDate()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfCreation",
                schema: "dbo",
                table: "Departments",
                type: "date",
                nullable: false,
                computedColumnSql: "GetDate()",
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
