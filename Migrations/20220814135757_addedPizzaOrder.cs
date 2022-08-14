﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPizzeria.Migrations;

public partial class addedPizzaOrder : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "pizzaOrders",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                BasePrice = table.Column<float>(type: "real", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_pizzaOrders", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "pizzaOrders");
    }
}
