using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopOne.Migrations
{
    public partial class ShopOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItems_Car_carid",
                table: "ShopCartItems");

            migrationBuilder.RenameColumn(
                name: "carid",
                table: "ShopCartItems",
                newName: "carId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ShopCartItems",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItems_carid",
                table: "ShopCartItems",
                newName: "IX_ShopCartItems_carId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Car",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrederTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_CarId",
                table: "OrderDetail",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItems_Car_carId",
                table: "ShopCartItems",
                column: "carId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItems_Car_carId",
                table: "ShopCartItems");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.RenameColumn(
                name: "carId",
                table: "ShopCartItems",
                newName: "carid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShopCartItems",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItems_carId",
                table: "ShopCartItems",
                newName: "IX_ShopCartItems_carid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Car",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItems_Car_carid",
                table: "ShopCartItems",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
