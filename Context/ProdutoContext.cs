using livrariaApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace livrariaApi.Context
{
    public class ProdutoContext: DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options): base(options)
        {

        }
        public DbSet<ProdutoCesta> ProdutosCesta { get; set; }
        
    }
}