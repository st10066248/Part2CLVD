using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Part2CLVD.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Orders",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Orders",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Orders",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Orders",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Orders",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Orders",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "Id");

            migrationBuilder.AddColumn<decimal>(
                name: "ItemPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
