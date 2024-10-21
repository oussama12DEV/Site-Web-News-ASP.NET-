using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetNews.Migrations
{
    public partial class firsttable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Newss");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Newss",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
