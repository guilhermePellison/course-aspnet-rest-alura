using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}