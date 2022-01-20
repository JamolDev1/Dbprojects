using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lesson1.Migrations
{
    public partial class _2ndCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AccountDb",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AccountDb");
        }
    }
}
