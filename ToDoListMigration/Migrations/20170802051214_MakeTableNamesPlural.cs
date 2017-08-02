using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListMigration.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropForeignKey(name: "FK_Item_Category_CategoryId", table: "Item");
			migrationBuilder.RenameTable(
				name: "Item",
				newName: "Items");
			migrationBuilder.RenameTable(
				name: "Category",
				newName: "Categories");
			migrationBuilder.AddForeignKey(
				name: "FK_Item_Category_CategoryId",
				table: "Items",
				column: "CategoryId",
				principalTable: "Categories",
				principalColumn: "CategoryId",
				onDelete: ReferentialAction.Cascade);

		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
