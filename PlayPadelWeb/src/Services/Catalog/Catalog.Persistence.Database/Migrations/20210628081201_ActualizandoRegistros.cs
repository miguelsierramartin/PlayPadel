using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class ActualizandoRegistros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Catalog",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                schema: "Catalog",
                table: "Products",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 1", 973m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 2", 818m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 3", 699m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 4", 739m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 5", 164m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 6", 791m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 7", 550m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 8", 272m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 9", 415m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 10", 654m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 11", 185m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 12", 431m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 13", 713m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Nombre",
                value: "Product 14");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 15", 625m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 16", 714m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 17", 360m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 18", 182m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 19", 927m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 20", 193m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 21", 930m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 22", 801m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 23", 984m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 24", 364m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 25", 322m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 26", 404m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 27", 524m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 28", 812m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 29", 877m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 30", 126m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 31", 208m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 32", 544m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 33", 730m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 34", 649m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 35", 213m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 36", 530m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 37", 130m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 38", 713m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 39", 473m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 40", 247m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 41", 736m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 42", 301m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 43", 720m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 44", 537m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 45", 378m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 46", 498m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 47", 756m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 48", 984m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 49", 438m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 50", 902m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 51", 245m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 52", 266m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 53", 225m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 54", 967m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 55", 668m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 56", 272m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 57", 833m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 58", 434m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 59", 517m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 60", 759m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 61", 367m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 62", 737m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 63", 394m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 64", 389m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 65", 545m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 66", 641m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 67", 700m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 68", 163m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 69", 479m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 70", 194m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 71", 684m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 72", 646m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 73", 709m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 74", 779m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 75", 457m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 76", 728m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 77", 180m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 78", 546m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 79", 985m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 80", 824m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 81", 648m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 82", 540m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 83", 474m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 84", 974m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 85", 881m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 86", 942m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 87", 418m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 88", 763m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 89", 980m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 90", 941m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 91", 697m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 92", 695m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 93", 296m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 94", 713m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 95", 880m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 96", 999m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 97", 906m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 98", 431m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 99", 992m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                columns: new[] { "Nombre", "Price" },
                values: new object[] { "Product 100", 737m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 1,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 2,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 3,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 4,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 5,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 6,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 7,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 8,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 9,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 10,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 11,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 12,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 13,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 14,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 15,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 16,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 17,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 18,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 19,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 21,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 22,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 23,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 24,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 25,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 26,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 27,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 28,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 29,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 30,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 31,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 32,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 33,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 34,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 35,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 36,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 37,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 38,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 39,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 40,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 41,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 42,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 43,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 44,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 45,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 46,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 48,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 49,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 50,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 51,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 52,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 53,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 54,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 55,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 56,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 57,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 58,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 59,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 60,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 61,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 62,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 63,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 64,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 65,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 66,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 67,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 68,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 69,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 70,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 71,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 72,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 73,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 74,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 75,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 76,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 77,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 78,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 79,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 80,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 81,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 82,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 83,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 84,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 86,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 87,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 88,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 89,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 90,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 91,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 92,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 93,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 94,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 95,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 96,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 97,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 98,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 99,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 100,
                column: "Stock",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                schema: "Catalog",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Catalog",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 1", 654m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 2", 443m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 3", 850m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 4", 676m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 5", 680m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 6", 726m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 7", 340m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 8", 681m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 9", 277m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 10", 123m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 11", 253m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 12", 158m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 13", 290m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Name",
                value: "Product 14");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 15", 390m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 16", 206m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 17", 159m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 18", 207m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 19", 765m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 20", 689m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 21", 816m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 22", 786m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 23", 786m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 24", 764m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 25", 912m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 26", 298m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 27", 763m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 28", 825m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 29", 281m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 30", 665m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 31", 370m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 32", 329m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 33", 943m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 34", 379m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 35", 684m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 36", 637m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 37", 687m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 38", 881m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 39", 242m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 40", 717m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 41", 732m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 42", 982m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 43", 460m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 44", 974m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 45", 653m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 46", 838m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 47", 852m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 48", 979m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 49", 457m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 50", 394m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 51", 604m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 52", 424m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 53", 434m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 54", 276m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 55", 171m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 56", 867m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 57", 657m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 58", 185m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 59", 764m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 60", 482m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 61", 962m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 62", 514m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 63", 499m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 64", 612m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 65", 753m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 66", 924m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 67", 214m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 68", 911m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 69", 909m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 70", 753m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 71", 519m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 72", 278m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 73", 965m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 74", 148m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 75", 957m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 76", 834m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 77", 425m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 78", 811m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 79", 211m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 80", 173m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 81", 445m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 82", 784m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 83", 467m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 84", 887m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 85", 160m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 86", 945m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 87", 894m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 88", 766m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 89", 308m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 90", 816m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 91", 980m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 92", 601m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 93", 217m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 94", 760m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 95", 754m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 96", 318m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 97", 582m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 98", 848m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 99", 320m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Product 100", 729m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 1,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 2,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 3,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 4,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 5,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 6,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 7,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 8,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 9,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 10,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 11,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 12,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 13,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 14,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 15,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 16,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 17,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 18,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 19,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 21,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 22,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 23,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 24,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 25,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 26,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 27,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 28,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 29,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 30,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 31,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 32,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 33,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 34,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 35,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 36,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 37,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 38,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 39,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 40,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 41,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 42,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 43,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 44,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 45,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 46,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 48,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 49,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 50,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 51,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 52,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 53,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 54,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 55,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 56,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 57,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 58,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 59,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 60,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 61,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 62,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 63,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 64,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 65,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 66,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 67,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 68,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 69,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 70,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 71,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 72,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 73,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 74,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 75,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 76,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 77,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 78,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 79,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 80,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 81,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 82,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 83,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 84,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 86,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 87,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 88,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 89,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 90,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 91,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 92,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 93,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 94,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 95,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 96,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 97,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 98,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 99,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 100,
                column: "Stock",
                value: 18);
        }
    }
}
