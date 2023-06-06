using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoschBootcamp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class second_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaID",
                table: "Departments",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "DepartmentBudget",
                table: "Departments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentBudget",
                table: "Departments");
        }
    }
}
