using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreDepartmantProject.Migrations
{
    public partial class personalmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departmants",
                columns: table => new
                {
                    deptid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deptname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmants", x => x.deptid);
                });

            migrationBuilder.CreateTable(
                name: "personals",
                columns: table => new
                {
                    personalid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personalname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personallastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personalsehir = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personals", x => x.personalid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departmants");

            migrationBuilder.DropTable(
                name: "personals");
        }
    }
}
