using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersBC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document = table.Column<string>(type: "varchar(15)", nullable: false),
                    firstName = table.Column<string>(type: "varchar(25)", nullable: false),
                    secondName = table.Column<string>(type: "varchar(25)", nullable: false),
                    lastName = table.Column<string>(type: "varchar(25)", nullable: false),
                    lastName2 = table.Column<string>(type: "varchar(25)", nullable: false),
                    phone = table.Column<string>(type: "varchar(15)", nullable: false),
                    email = table.Column<string>(type: "varchar(40)", nullable: false),
                    address = table.Column<string>(type: "varchar(40)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    genre = table.Column<string>(type: "varchar(10)", nullable: false)
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
