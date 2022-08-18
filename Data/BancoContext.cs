using Microsoft.EntityFrameworkCore;
using AplicacaoProjetoMVC.Models;

namespace AplicacaoProjetoMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> ContatoModels { get; set; }
    }
}
