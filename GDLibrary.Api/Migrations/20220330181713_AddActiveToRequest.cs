using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GDLibrary.Api.Migrations
{
    public partial class AddActiveToRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                schema: "public",
                table: "Requests",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                schema: "public",
                table: "Requests");
        }
    }
}
