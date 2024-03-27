using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreDepartmantProject.Migrations
{
    public partial class newdetailcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detail",
                table: "departmants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detail",
                table: "departmants");
        }
    }
}
