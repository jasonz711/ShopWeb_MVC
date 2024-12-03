using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modifyShoppingCardField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "shoppingCarts",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "shoppingCarts",
                newName: "ID");
        }
    }
}
