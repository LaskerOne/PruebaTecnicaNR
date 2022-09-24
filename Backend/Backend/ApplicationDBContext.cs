using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend
{
    public class ApplicationDBContext : DbContext
    {
        //builder
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        
        public DbSet<UsersBC> UsersBC { get; set; }

    }
}
