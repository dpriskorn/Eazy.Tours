using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eazy.Tours.Migrations
{
    public partial class Password_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "Users",
                type: "int",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Users",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "Users",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 16)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
