using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Part2CLVD.Migrations
{
    /// <inheritdoc />
    public partial class fouth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ItemPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "Orders");
        }
    }
}
