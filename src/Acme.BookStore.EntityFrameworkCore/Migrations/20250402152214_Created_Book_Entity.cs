using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Created_Book_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "leftNum",
                table: "AppBooks",
                newName: "LeftNum");

            migrationBuilder.AddColumn<int>(
                name: "BooknNum",
                table: "OrderDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BooknNum",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "LeftNum",
                table: "AppBooks",
                newName: "leftNum");
        }
    }
}
