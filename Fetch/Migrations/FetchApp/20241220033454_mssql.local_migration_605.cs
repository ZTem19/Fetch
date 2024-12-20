using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FetchApp.Migrations.FetchApp
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_605 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DogListing",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "DogListing");
        }
    }
}
