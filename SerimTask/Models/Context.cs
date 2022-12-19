using Microsoft.EntityFrameworkCore;

namespace SerimTask.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Musteri> Musteriler { get; set; }
    }
}
