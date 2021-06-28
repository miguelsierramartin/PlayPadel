using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class ActualizandoDescripcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Catalog",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                schema: "Catalog",
                table: "Products",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 1", 937m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 2", 772m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 3", 314m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 4", 751m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 5", 654m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 6", 964m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 7", 560m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 8", 858m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 9", 820m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 10", 307m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 11", 155m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 12", 777m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 13", 938m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 14", 471m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 15", 357m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 16", 513m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 17", 603m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 18", 207m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 19", 510m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 20", 294m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 21", 658m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 22", 720m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 23", 584m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 24", 103m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 25", 810m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 26", 141m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 27", 770m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 28", 365m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 29", 879m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 30", 570m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 31", 315m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 32", 650m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 33", 743m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 34", 171m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 35", 522m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 36", 868m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 37", 857m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 38", 179m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 39", 493m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 40", 485m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 41", 988m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 42", 570m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 43", 542m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 44", 397m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 45", 580m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 46", 821m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 47", 363m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 48", 149m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 49", 662m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 50", 211m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 51", 453m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 52", 714m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 53", 964m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 54", 265m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 55", 857m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 56", 317m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 57", 287m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 58", 310m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 59", 941m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 60", 613m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 61", 293m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 62", 294m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 63", 979m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 64", 350m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 65", 991m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 66", 504m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 67", 133m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 68", 866m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 69", 949m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 70", 488m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 71", 655m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 72", 523m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 73", 714m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 74", 125m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 75", 306m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 76", 187m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 77", 278m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 78", 286m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 79", 523m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 80", 989m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 81", 777m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 82", 721m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 83", 703m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 84", 767m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 85", 217m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 86", 601m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 87", 686m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 88", 577m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 89", 314m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 90", 305m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 91", 681m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 92", 647m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 93", 237m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 94", 879m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 95", 291m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 96", 793m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 97", 591m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 98", 292m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 99", 406m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                columns: new[] { "Descripcion", "Price" },
                values: new object[] { "Description for product 100", 175m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 1,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 2,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 3,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 4,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 5,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 6,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 7,
                column: "Stock",
                value: 3);

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
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 10,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 11,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 13,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 14,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 15,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 16,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 17,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 18,
                column: "Stock",
                value: 2);

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
                keyValue: 20,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 21,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 22,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 23,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 24,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 25,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 26,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 27,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 28,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 29,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 30,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 31,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 32,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 33,
                column: "Stock",
                value: 18);

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
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 36,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 37,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 38,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 39,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 40,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 41,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 42,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 44,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 45,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 46,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 47,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 48,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 49,
                column: "Stock",
                value: 9);

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
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 53,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 54,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 55,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 56,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 57,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 58,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 59,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 60,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 61,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 62,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 63,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 64,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 65,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 66,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 67,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 68,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 69,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 70,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 71,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 72,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 73,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 74,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 75,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 76,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 77,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 78,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 79,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 80,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 81,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 83,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 84,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 85,
                column: "Stock",
                value: 18);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 86,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 87,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 88,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 89,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 90,
                column: "Stock",
                value: 16);

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
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 93,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 94,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 95,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 96,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 97,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 98,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 99,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 100,
                column: "Stock",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                schema: "Catalog",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Catalog",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 1", 973m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 2", 818m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 3", 699m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 4", 739m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 5", 164m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 6", 791m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 7", 550m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 8", 272m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 9", 415m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 10", 654m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 11", 185m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 12", 431m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 13", 713m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 14", 593m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 15", 625m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 16", 714m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 17", 360m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 18", 182m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 19", 927m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 20", 193m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 21", 930m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 22", 801m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 23", 984m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 24", 364m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 25", 322m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 26", 404m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 27", 524m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 28", 812m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 29", 877m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 30", 126m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 31", 208m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 32", 544m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 33", 730m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 34", 649m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 35", 213m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 36", 530m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 37", 130m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 38", 713m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 39", 473m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 40", 247m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 41", 736m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 42", 301m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 43", 720m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 44", 537m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 45", 378m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 46", 498m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 47", 756m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 48", 984m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 49", 438m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 50", 902m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 51", 245m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 52", 266m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 53", 225m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 54", 967m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 55", 668m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 56", 272m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 57", 833m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 58", 434m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 59", 517m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 60", 759m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 61", 367m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 62", 737m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 63", 394m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 64", 389m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 65", 545m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 66", 641m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 67", 700m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 68", 163m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 69", 479m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 70", 194m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 71", 684m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 72", 646m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 73", 709m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 74", 779m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 75", 457m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 76", 728m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 77", 180m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 78", 546m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 79", 985m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 80", 824m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 81", 648m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 82", 540m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 83", 474m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 84", 974m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 85", 881m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 86", 942m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 87", 418m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 88", 763m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 89", 980m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 90", 941m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 91", 697m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 92", 695m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 93", 296m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 94", 713m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 95", 880m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 96", 999m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 97", 906m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 98", 431m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 99", 992m });

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Description for product 100", 737m });

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
                keyValue: 20,
                column: "Stock",
                value: 11);

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
                keyValue: 47,
                column: "Stock",
                value: 16);

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
                keyValue: 85,
                column: "Stock",
                value: 4);

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
    }
}
