using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreDepartmantProject.Migrations
{
    public partial class removedetailcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detail",
                table: "departmants");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detail",
                table: "departmants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
