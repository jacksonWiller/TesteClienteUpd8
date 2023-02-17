using ClienteUpd8.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteUpd8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
