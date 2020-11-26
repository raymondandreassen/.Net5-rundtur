using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo1.Server.Migrations
{
    public partial class extras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SomeInfo",
                table: "Department",
                newName: "DepartmentInfo");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "BlogPosts",
                newName: "InfoId");

            migrationBuilder.AddColumn<string>(
                name: "SomeInfo",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SomeInfo",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "DepartmentInfo",
                table: "Department",
                newName: "SomeInfo");

            migrationBuilder.RenameColumn(
                name: "InfoId",
                table: "BlogPosts",
                newName: "BlogId");
        }
    }
}
