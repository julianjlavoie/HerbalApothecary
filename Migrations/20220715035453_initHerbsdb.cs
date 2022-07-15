using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HerbalApothecary.Migrations
{
    public partial class initHerbsdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    HerbExtraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KeyConstituents = table.Column<string>(type: "TEXT", nullable: true),
                    ResearchFindings = table.Column<int>(type: "INTEGER", nullable: false),
                    BotanicalName = table.Column<int>(type: "INTEGER", nullable: false),
                    PartsUsed = table.Column<int>(type: "INTEGER", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Referances = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.HerbExtraId);
                });

            migrationBuilder.CreateTable(
                name: "Herbs",
                columns: table => new
                {
                    HerbId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommonName = table.Column<string>(type: "TEXT", nullable: true),
                    Uses = table.Column<string>(type: "TEXT", nullable: true),
                    Contraindications = table.Column<string>(type: "TEXT", nullable: true),
                    SideEffects = table.Column<string>(type: "TEXT", nullable: true),
                    Tincture = table.Column<string>(type: "TEXT", nullable: true),
                    Powder = table.Column<string>(type: "TEXT", nullable: true),
                    Actions = table.Column<string>(type: "TEXT", nullable: true),
                    Decoction = table.Column<string>(type: "TEXT", nullable: true),
                    Energy = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Safety = table.Column<string>(type: "TEXT", nullable: true),
                    HerbExtraId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herbs", x => x.HerbId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    InventoryItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HerbId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.InventoryItemId);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HerbId = table.Column<int>(type: "INTEGER", nullable: false),
                    InventoryItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    PriceMetric = table.Column<string>(type: "TEXT", nullable: true),
                    Vendor = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Herbs");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Purchases");
        }
    }
}
