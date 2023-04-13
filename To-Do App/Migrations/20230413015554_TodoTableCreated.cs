using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_App.Migrations
{
    public partial class TodoTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[,]
                {
                    { "Assignment", true },
                    { "Barbing", false },
                    { "Exercise", false },
                    { "Go to church", true },
                    { "Meeting", true },
                    { "Shopping", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
