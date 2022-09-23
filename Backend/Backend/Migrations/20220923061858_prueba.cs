using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersBC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    firstName = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    secondName = table.Column<string>(type: "varchar(25)", nullable: true),
                    lastName = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    lastName2 = table.Column<string>(type: "varchar(25)", nullable: true),
                    phone = table.Column<string>(type: "varchar(15)", nullable: true),
                    email = table.Column<string>(type: "varchar(40)", nullable: true),
                    address = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    genre = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersBC", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersBC");
        }
    }
}
