using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ModeloBase.Data
{
    public class DataContext: DbContext
    {
       public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
