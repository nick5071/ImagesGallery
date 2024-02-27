using Microsoft.EntityFrameworkCore;

namespace Images_Gallery.Models
{
    public class Conexao : DbContext 
    {
        public Conexao (DbContextOptions<Conexao> options) : base(options)
        {

        }
        public DbSet<ImagemModel> Imagens { get; set; }
    }
}
