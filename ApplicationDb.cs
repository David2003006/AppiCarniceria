using Microsoft.EntityFrameworkCore;
using WebAppCarniceria.BD;

namespace WebAppCarniceria
{
    public class ApplicationDb
    {
        public class AplicationDbContext : DbContext
        {
            public AplicationDbContext(DbContextOptions options) : base(options) {}

            public DbSet<Carniceria> Carniceria { get; set; }
            public DbSet<Provedor> Provedor { get; set; }
        }
            
               
    }
}


        
            
            
        
    


   




