using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_18_Coffee_Shop_Part_1.Migrations
{
    public partial class Shop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    Regular = table.Column<bool>(nullable: false),
                    Member = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
