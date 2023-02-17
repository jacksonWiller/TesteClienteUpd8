using ClienteUpd8.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteUpd8.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
         
        public DbSet<Cliente> Clientes { get; set; }

    }
}
