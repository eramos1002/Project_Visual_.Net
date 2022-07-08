//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MySecondProject.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }

    }
}
