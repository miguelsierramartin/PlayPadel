using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class ActualizandoPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                schema: "Catalog",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                schema: "Catalog",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Precio",
                value: 776m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Precio",
                value: 778m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Precio",
                value: 889m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Precio",
                value: 245m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Precio",
                value: 282m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Precio",
                value: 177m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Precio",
                value: 274m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Precio",
                value: 919m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Precio",
                value: 113m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Precio",
                value: 830m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Precio",
                value: 520m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Precio",
                value: 239m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Precio",
                value: 443m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Precio",
                value: 429m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Precio",
                value: 905m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Precio",
                value: 970m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Precio",
                value: 303m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Precio",
                value: 300m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "Precio",
                value: 167m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "Precio",
                value: 393m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "Precio",
                value: 155m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "Precio",
                value: 326m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "Precio",
                value: 280m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "Precio",
                value: 881m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "Precio",
                value: 380m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "Precio",
                value: 938m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "Precio",
                value: 378m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "Precio",
                value: 177m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "Precio",
                value: 195m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "Precio",
                value: 402m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "Precio",
                value: 371m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "Precio",
                value: 597m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "Precio",
                value: 608m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "Precio",
                value: 984m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "Precio",
                value: 288m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "Precio",
                value: 820m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "Precio",
                value: 453m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "Precio",
                value: 121m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "Precio",
                value: 324m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "Precio",
                value: 883m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "Precio",
                value: 673m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "Precio",
                value: 608m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "Precio",
                value: 157m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "Precio",
                value: 898m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "Precio",
                value: 694m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "Precio",
                value: 348m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "Precio",
                value: 703m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "Precio",
                value: 909m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "Precio",
                value: 477m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "Precio",
                value: 766m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "Precio",
                value: 388m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "Precio",
                value: 431m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "Precio",
                value: 625m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "Precio",
                value: 917m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "Precio",
                value: 636m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "Precio",
                value: 550m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "Precio",
                value: 598m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "Precio",
                value: 107m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "Precio",
                value: 864m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "Precio",
                value: 343m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "Precio",
                value: 798m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "Precio",
                value: 197m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "Precio",
                value: 824m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "Precio",
                value: 710m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "Precio",
                value: 558m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "Precio",
                value: 922m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "Precio",
                value: 631m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "Precio",
                value: 458m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "Precio",
                value: 240m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "Precio",
                value: 185m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "Precio",
                value: 617m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "Precio",
                value: 281m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "Precio",
                value: 976m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "Precio",
                value: 284m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "Precio",
                value: 719m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "Precio",
                value: 547m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "Precio",
                value: 268m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "Precio",
                value: 381m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "Precio",
                value: 286m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "Precio",
                value: 131m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "Precio",
                value: 334m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "Precio",
                value: 468m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "Precio",
                value: 699m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "Precio",
                value: 428m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "Precio",
                value: 114m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "Precio",
                value: 939m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "Precio",
                value: 971m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "Precio",
                value: 691m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "Precio",
                value: 447m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "Precio",
                value: 738m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "Precio",
                value: 321m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "Precio",
                value: 445m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "Precio",
                value: 257m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "Precio",
                value: 980m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "Precio",
                value: 184m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "Precio",
                value: 576m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "Precio",
                value: 783m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "Precio",
                value: 446m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "Precio",
                value: 439m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "Precio",
                value: 772m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 1,
                column: "Stock",
                value: 10);

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
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 4,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 5,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 6,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 7,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 8,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 9,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 10,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 11,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 12,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 13,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 14,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 15,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 16,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 17,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 18,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 19,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 20,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 21,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 22,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 24,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 25,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 26,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 27,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 28,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 29,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 30,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 31,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 32,
                column: "Stock",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 33,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 34,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 35,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 36,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 37,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 38,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 39,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 40,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 41,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 42,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 43,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 44,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 45,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 46,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 47,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 48,
                column: "Stock",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 49,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 50,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 51,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 52,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 53,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 54,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 55,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 56,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 57,
                column: "Stock",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 58,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 59,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 60,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 61,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 62,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 63,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 64,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 65,
                column: "Stock",
                value: 3);

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
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 68,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 69,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 70,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 71,
                column: "Stock",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 72,
                column: "Stock",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 73,
                column: "Stock",
                value: 19);

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
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 76,
                column: "Stock",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 77,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 78,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 79,
                column: "Stock",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 80,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 81,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 82,
                column: "Stock",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 83,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 84,
                column: "Stock",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 85,
                column: "Stock",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 86,
                column: "Stock",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 87,
                column: "Stock",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 88,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 89,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 91,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 92,
                column: "Stock",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 93,
                column: "Stock",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 94,
                column: "Stock",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 95,
                column: "Stock",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 97,
                column: "Stock",
                value: 17);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 98,
                column: "Stock",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 99,
                column: "Stock",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Stocks",
                keyColumn: "ProductInStockId",
                keyValue: 100,
                column: "Stock",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                schema: "Catalog",
                table: "Products");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                schema: "Catalog",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 937m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 772m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 314m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Price",
                value: 751m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 654m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 964m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 560m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 858m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 820m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 307m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 155m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 777m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 938m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 471m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 357m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 513m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 603m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 207m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                column: "Price",
                value: 510m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                column: "Price",
                value: 294m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                column: "Price",
                value: 658m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                column: "Price",
                value: 720m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                column: "Price",
                value: 584m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                column: "Price",
                value: 103m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                column: "Price",
                value: 810m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                column: "Price",
                value: 141m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                column: "Price",
                value: 770m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                column: "Price",
                value: 365m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                column: "Price",
                value: 879m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30,
                column: "Price",
                value: 570m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31,
                column: "Price",
                value: 315m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32,
                column: "Price",
                value: 650m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33,
                column: "Price",
                value: 743m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34,
                column: "Price",
                value: 171m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35,
                column: "Price",
                value: 522m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36,
                column: "Price",
                value: 868m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37,
                column: "Price",
                value: 857m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38,
                column: "Price",
                value: 179m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39,
                column: "Price",
                value: 493m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40,
                column: "Price",
                value: 485m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41,
                column: "Price",
                value: 988m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42,
                column: "Price",
                value: 570m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43,
                column: "Price",
                value: 542m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44,
                column: "Price",
                value: 397m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45,
                column: "Price",
                value: 580m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46,
                column: "Price",
                value: 821m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47,
                column: "Price",
                value: 363m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48,
                column: "Price",
                value: 149m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49,
                column: "Price",
                value: 662m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50,
                column: "Price",
                value: 211m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51,
                column: "Price",
                value: 453m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52,
                column: "Price",
                value: 714m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53,
                column: "Price",
                value: 964m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54,
                column: "Price",
                value: 265m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55,
                column: "Price",
                value: 857m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56,
                column: "Price",
                value: 317m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57,
                column: "Price",
                value: 287m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58,
                column: "Price",
                value: 310m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59,
                column: "Price",
                value: 941m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60,
                column: "Price",
                value: 613m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61,
                column: "Price",
                value: 293m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62,
                column: "Price",
                value: 294m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63,
                column: "Price",
                value: 979m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64,
                column: "Price",
                value: 350m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65,
                column: "Price",
                value: 991m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66,
                column: "Price",
                value: 504m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67,
                column: "Price",
                value: 133m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68,
                column: "Price",
                value: 866m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69,
                column: "Price",
                value: 949m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70,
                column: "Price",
                value: 488m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71,
                column: "Price",
                value: 655m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72,
                column: "Price",
                value: 523m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73,
                column: "Price",
                value: 714m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74,
                column: "Price",
                value: 125m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75,
                column: "Price",
                value: 306m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76,
                column: "Price",
                value: 187m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77,
                column: "Price",
                value: 278m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78,
                column: "Price",
                value: 286m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79,
                column: "Price",
                value: 523m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80,
                column: "Price",
                value: 989m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81,
                column: "Price",
                value: 777m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82,
                column: "Price",
                value: 721m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83,
                column: "Price",
                value: 703m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84,
                column: "Price",
                value: 767m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85,
                column: "Price",
                value: 217m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86,
                column: "Price",
                value: 601m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87,
                column: "Price",
                value: 686m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88,
                column: "Price",
                value: 577m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89,
                column: "Price",
                value: 314m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90,
                column: "Price",
                value: 305m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91,
                column: "Price",
                value: 681m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92,
                column: "Price",
                value: 647m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93,
                column: "Price",
                value: 237m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94,
                column: "Price",
                value: 879m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95,
                column: "Price",
                value: 291m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96,
                column: "Price",
                value: 793m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97,
                column: "Price",
                value: 591m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98,
                column: "Price",
                value: 292m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99,
                column: "Price",
                value: 406m);

            migrationBuilder.UpdateData(
                schema: "Catalog",
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100,
                column: "Price",
                value: 175m);

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
                keyValue: 12,
                column: "Stock",
                value: 6);

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
                keyValue: 43,
                column: "Stock",
                value: 14);

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
                keyValue: 82,
                column: "Stock",
                value: 12);

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
    }
}
