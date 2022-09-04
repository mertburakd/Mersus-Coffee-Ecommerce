using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Comment",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Rewiew = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DateTime = table.Column<DateTime>(type: "date", nullable: true),
                    Answer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "dbo",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Image1 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Image2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Image3 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Image4 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Image5 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiniDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiniImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Card_Product",
                        column: x => x.ProductID,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "Watch",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watch", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Watch_Product",
                        column: x => x.ProductID,
                        principalSchema: "dbo",
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "dbo",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "date", nullable: true),
                    EndTime = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Card",
                        column: x => x.CardID,
                        principalSchema: "dbo",
                        principalTable: "Card",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_ProductID",
                schema: "dbo",
                table: "Card",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CardID",
                schema: "dbo",
                table: "Order",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Watch_ProductID",
                schema: "dbo",
                table: "Watch",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FeedBack",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Watch",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Card",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "dbo");
        }
    }
}
