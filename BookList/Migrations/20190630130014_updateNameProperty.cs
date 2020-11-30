using Microsoft.EntityFrameworkCore.Migrations;

namespace BookList.Migrations
{
    public partial class updateNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "books",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "books",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "books",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "books",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "books",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
