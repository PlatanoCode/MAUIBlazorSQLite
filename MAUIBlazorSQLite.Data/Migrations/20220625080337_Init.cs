using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAUIBlazorSQLite.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DayOfTheWeekText = table.Column<string>(type: "TEXT", nullable: false),
                    TitleText = table.Column<string>(type: "TEXT", nullable: false),
                    DescriptionText = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDo");
        }
    }
}
