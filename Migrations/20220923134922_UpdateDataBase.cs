using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestEntityEmbbeded.Migrations
{
    public partial class UpdateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact_Contact",
                table: "tb_company");

            migrationBuilder.RenameColumn(
                name: "Contact_Phone",
                table: "tb_company",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Contact_Email",
                table: "tb_company",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "tb_company",
                newName: "Contact_Phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "tb_company",
                newName: "Contact_Email");

            migrationBuilder.AddColumn<string>(
                name: "Contact_Contact",
                table: "tb_company",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
