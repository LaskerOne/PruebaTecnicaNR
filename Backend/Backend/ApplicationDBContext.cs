using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend
{
    public class ApplicationDBContext : DbContext
    {
        //builder
        //Constructor que recibe la cadena de conexxión desde el appsetings
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        
        //Instancia de la clase con el nombre de la base de datos
        public DbSet<UsersBC> UsersBC { get; set; }

    }
}
