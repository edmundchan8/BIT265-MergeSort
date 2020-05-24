using Microsoft.EntityFrameworkCore.Migrations;

namespace BIT265_MergeSort.Migrations
{
    public partial class mergesortmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WifiHotSpots",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FSCSKEY = table.Column<string>(nullable: true),
                    LIBID = table.Column<string>(nullable: true),
                    LibrarySystem = table.Column<string>(nullable: true),
                    BranchLibrary = table.Column<string>(nullable: true),
                    WiFiHours = table.Column<string>(nullable: true),
                    Password = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZIP = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    OutletType = table.Column<string>(nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    Website = table.Column<string>(nullable: true),
                    eCardAccess = table.Column<bool>(nullable: false),
                    LastUpdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WifiHotspots", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WifiHotSpots");
        }
    }
}
