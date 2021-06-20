using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Inicializar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 654m },
                    { 73, "Description for product 73", "Product 73", 965m },
                    { 72, "Description for product 72", "Product 72", 278m },
                    { 71, "Description for product 71", "Product 71", 519m },
                    { 70, "Description for product 70", "Product 70", 753m },
                    { 69, "Description for product 69", "Product 69", 909m },
                    { 68, "Description for product 68", "Product 68", 911m },
                    { 67, "Description for product 67", "Product 67", 214m },
                    { 66, "Description for product 66", "Product 66", 924m },
                    { 65, "Description for product 65", "Product 65", 753m },
                    { 64, "Description for product 64", "Product 64", 612m },
                    { 63, "Description for product 63", "Product 63", 499m },
                    { 62, "Description for product 62", "Product 62", 514m },
                    { 61, "Description for product 61", "Product 61", 962m },
                    { 60, "Description for product 60", "Product 60", 482m },
                    { 59, "Description for product 59", "Product 59", 764m },
                    { 58, "Description for product 58", "Product 58", 185m },
                    { 57, "Description for product 57", "Product 57", 657m },
                    { 56, "Description for product 56", "Product 56", 867m },
                    { 55, "Description for product 55", "Product 55", 171m },
                    { 54, "Description for product 54", "Product 54", 276m },
                    { 53, "Description for product 53", "Product 53", 434m },
                    { 74, "Description for product 74", "Product 74", 148m },
                    { 52, "Description for product 52", "Product 52", 424m },
                    { 75, "Description for product 75", "Product 75", 957m },
                    { 77, "Description for product 77", "Product 77", 425m },
                    { 98, "Description for product 98", "Product 98", 848m },
                    { 97, "Description for product 97", "Product 97", 582m },
                    { 96, "Description for product 96", "Product 96", 318m },
                    { 95, "Description for product 95", "Product 95", 754m },
                    { 94, "Description for product 94", "Product 94", 760m },
                    { 93, "Description for product 93", "Product 93", 217m },
                    { 92, "Description for product 92", "Product 92", 601m },
                    { 91, "Description for product 91", "Product 91", 980m },
                    { 90, "Description for product 90", "Product 90", 816m },
                    { 89, "Description for product 89", "Product 89", 308m },
                    { 88, "Description for product 88", "Product 88", 766m },
                    { 87, "Description for product 87", "Product 87", 894m },
                    { 86, "Description for product 86", "Product 86", 945m },
                    { 85, "Description for product 85", "Product 85", 160m },
                    { 84, "Description for product 84", "Product 84", 887m },
                    { 83, "Description for product 83", "Product 83", 467m },
                    { 82, "Description for product 82", "Product 82", 784m },
                    { 81, "Description for product 81", "Product 81", 445m },
                    { 80, "Description for product 80", "Product 80", 173m },
                    { 79, "Description for product 79", "Product 79", 211m },
                    { 78, "Description for product 78", "Product 78", 811m },
                    { 76, "Description for product 76", "Product 76", 834m },
                    { 51, "Description for product 51", "Product 51", 604m },
                    { 50, "Description for product 50", "Product 50", 394m },
                    { 49, "Description for product 49", "Product 49", 457m },
                    { 22, "Description for product 22", "Product 22", 786m },
                    { 21, "Description for product 21", "Product 21", 816m },
                    { 20, "Description for product 20", "Product 20", 689m },
                    { 19, "Description for product 19", "Product 19", 765m },
                    { 18, "Description for product 18", "Product 18", 207m },
                    { 17, "Description for product 17", "Product 17", 159m },
                    { 16, "Description for product 16", "Product 16", 206m },
                    { 15, "Description for product 15", "Product 15", 390m },
                    { 14, "Description for product 14", "Product 14", 593m },
                    { 13, "Description for product 13", "Product 13", 290m },
                    { 12, "Description for product 12", "Product 12", 158m },
                    { 11, "Description for product 11", "Product 11", 253m },
                    { 10, "Description for product 10", "Product 10", 123m },
                    { 9, "Description for product 9", "Product 9", 277m },
                    { 8, "Description for product 8", "Product 8", 681m },
                    { 7, "Description for product 7", "Product 7", 340m },
                    { 6, "Description for product 6", "Product 6", 726m },
                    { 5, "Description for product 5", "Product 5", 680m },
                    { 4, "Description for product 4", "Product 4", 676m },
                    { 3, "Description for product 3", "Product 3", 850m },
                    { 2, "Description for product 2", "Product 2", 443m },
                    { 23, "Description for product 23", "Product 23", 786m },
                    { 24, "Description for product 24", "Product 24", 764m },
                    { 25, "Description for product 25", "Product 25", 912m },
                    { 26, "Description for product 26", "Product 26", 298m },
                    { 48, "Description for product 48", "Product 48", 979m },
                    { 47, "Description for product 47", "Product 47", 852m },
                    { 46, "Description for product 46", "Product 46", 838m },
                    { 45, "Description for product 45", "Product 45", 653m },
                    { 44, "Description for product 44", "Product 44", 974m },
                    { 43, "Description for product 43", "Product 43", 460m },
                    { 42, "Description for product 42", "Product 42", 982m },
                    { 41, "Description for product 41", "Product 41", 732m },
                    { 40, "Description for product 40", "Product 40", 717m },
                    { 39, "Description for product 39", "Product 39", 242m },
                    { 99, "Description for product 99", "Product 99", 320m },
                    { 38, "Description for product 38", "Product 38", 881m },
                    { 36, "Description for product 36", "Product 36", 637m },
                    { 35, "Description for product 35", "Product 35", 684m },
                    { 34, "Description for product 34", "Product 34", 379m },
                    { 33, "Description for product 33", "Product 33", 943m },
                    { 32, "Description for product 32", "Product 32", 329m },
                    { 31, "Description for product 31", "Product 31", 370m },
                    { 30, "Description for product 30", "Product 30", 665m },
                    { 29, "Description for product 29", "Product 29", 281m },
                    { 28, "Description for product 28", "Product 28", 825m },
                    { 27, "Description for product 27", "Product 27", 763m },
                    { 37, "Description for product 37", "Product 37", 687m },
                    { 100, "Description for product 100", "Product 100", 729m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 8 },
                    { 73, 73, 4 },
                    { 72, 72, 8 },
                    { 71, 71, 8 },
                    { 70, 70, 9 },
                    { 69, 69, 19 },
                    { 68, 68, 0 },
                    { 67, 67, 4 },
                    { 66, 66, 11 },
                    { 65, 65, 0 },
                    { 64, 64, 6 },
                    { 63, 63, 8 },
                    { 62, 62, 3 },
                    { 61, 61, 9 },
                    { 60, 60, 7 },
                    { 59, 59, 16 },
                    { 58, 58, 9 },
                    { 57, 57, 9 },
                    { 56, 56, 6 },
                    { 55, 55, 10 },
                    { 54, 54, 3 },
                    { 53, 53, 5 },
                    { 74, 74, 12 },
                    { 52, 52, 14 },
                    { 75, 75, 4 },
                    { 77, 77, 19 },
                    { 98, 98, 15 },
                    { 97, 97, 9 },
                    { 96, 96, 4 },
                    { 95, 95, 7 },
                    { 94, 94, 10 },
                    { 93, 93, 15 },
                    { 92, 92, 1 },
                    { 91, 91, 15 },
                    { 90, 90, 15 },
                    { 89, 89, 14 },
                    { 88, 88, 4 },
                    { 87, 87, 12 },
                    { 86, 86, 18 },
                    { 85, 85, 4 },
                    { 84, 84, 8 },
                    { 83, 83, 13 },
                    { 82, 82, 11 },
                    { 81, 81, 1 },
                    { 80, 80, 3 },
                    { 79, 79, 1 },
                    { 78, 78, 17 },
                    { 76, 76, 2 },
                    { 51, 51, 14 },
                    { 50, 50, 2 },
                    { 49, 49, 3 },
                    { 22, 22, 1 },
                    { 21, 21, 1 },
                    { 20, 20, 11 },
                    { 19, 19, 8 },
                    { 18, 18, 3 },
                    { 17, 17, 1 },
                    { 16, 16, 19 },
                    { 15, 15, 14 },
                    { 14, 14, 1 },
                    { 13, 13, 5 },
                    { 12, 12, 12 },
                    { 11, 11, 10 },
                    { 10, 10, 13 },
                    { 9, 9, 5 },
                    { 8, 8, 0 },
                    { 7, 7, 0 },
                    { 6, 6, 6 },
                    { 5, 5, 6 },
                    { 4, 4, 8 },
                    { 3, 3, 1 },
                    { 2, 2, 7 },
                    { 23, 23, 17 },
                    { 24, 24, 11 },
                    { 25, 25, 11 },
                    { 26, 26, 18 },
                    { 48, 48, 5 },
                    { 47, 47, 16 },
                    { 46, 46, 7 },
                    { 45, 45, 10 },
                    { 44, 44, 19 },
                    { 43, 43, 2 },
                    { 42, 42, 18 },
                    { 41, 41, 7 },
                    { 40, 40, 16 },
                    { 39, 39, 18 },
                    { 99, 99, 19 },
                    { 38, 38, 12 },
                    { 36, 36, 4 },
                    { 35, 35, 1 },
                    { 34, 34, 5 },
                    { 33, 33, 7 },
                    { 32, 32, 18 },
                    { 31, 31, 13 },
                    { 30, 30, 19 },
                    { 29, 29, 11 },
                    { 28, 28, 17 },
                    { 27, 27, 17 },
                    { 37, 37, 11 },
                    { 100, 100, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
