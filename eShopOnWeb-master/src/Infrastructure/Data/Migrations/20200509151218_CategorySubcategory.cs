using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.eShopWeb.Infrastructure.Data.Migrations
{
    public partial class CategorySubcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "category_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "sub_category_hilo",
                incrementBy: 10);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "OrderItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "OrderItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "OrderItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "OrderItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CatalogTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CatalogTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "CatalogTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CatalogTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CatalogBrands",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CatalogBrands",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "CatalogBrands",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CatalogBrands",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Catalog",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Catalog",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Catalog",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Catalog",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Baskets",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Baskets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Baskets",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Baskets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "BasketItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "BasketItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(maxLength: 300, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(maxLength: 300, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropSequence(
                name: "category_hilo");

            migrationBuilder.DropSequence(
                name: "sub_category_hilo");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CatalogTypes");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CatalogTypes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "CatalogTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CatalogTypes");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CatalogBrands");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CatalogBrands");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "CatalogBrands");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CatalogBrands");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "BasketItems");
        }
    }
}
