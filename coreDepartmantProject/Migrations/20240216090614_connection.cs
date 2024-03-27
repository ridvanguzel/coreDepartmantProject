using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreDepartmantProject.Migrations
{
    public partial class connection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departdeptid",
                table: "personals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_personals_departdeptid",
                table: "personals",
                column: "departdeptid");

            migrationBuilder.AddForeignKey(
                name: "FK_personals_departmants_departdeptid",
                table: "personals",
                column: "departdeptid",
                principalTable: "departmants",
                principalColumn: "deptid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personals_departmants_departdeptid",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "IX_personals_departdeptid",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "departdeptid",
                table: "personals");
        }
    }
}
