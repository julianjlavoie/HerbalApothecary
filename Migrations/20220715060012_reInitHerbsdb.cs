using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HerbalApothecary.Migrations
{
    public partial class reInitHerbsdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropColumn(
                name: "HerbExtraId",
                table: "Herbs");

            migrationBuilder.AddColumn<string>(
                name: "BotanicalName",
                table: "Herbs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Herbs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyConstituents",
                table: "Herbs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartsUsed",
                table: "Herbs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Referances",
                table: "Herbs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResearchFindings",
                table: "Herbs",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BotanicalName",
                table: "Herbs");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Herbs");

            migrationBuilder.DropColumn(
                name: "KeyConstituents",
                table: "Herbs");

            migrationBuilder.DropColumn(
                name: "PartsUsed",
                table: "Herbs");

            migrationBuilder.DropColumn(
                name: "Referances",
                table: "Herbs");

            migrationBuilder.DropColumn(
                name: "ResearchFindings",
                table: "Herbs");

            migrationBuilder.AddColumn<int>(
                name: "HerbExtraId",
                table: "Herbs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    HerbExtraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BotanicalName = table.Column<int>(type: "INTEGER", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    KeyConstituents = table.Column<string>(type: "TEXT", nullable: true),
                    PartsUsed = table.Column<int>(type: "INTEGER", nullable: false),
                    Referances = table.Column<string>(type: "TEXT", nullable: true),
                    ResearchFindings = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.HerbExtraId);
                });
        }
    }
}
