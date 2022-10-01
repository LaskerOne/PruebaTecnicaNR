using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class prueba : Migration
    {
        //Migración de la base de datos
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //El método elaborado por Entity para crear la tabla donde se almacenaran los registros
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

        //Método creado por entity para eliminar la tabla de la base de datos en caso de requerirse
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersBC");
        }

        
    }
}
