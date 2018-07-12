using CapgeminiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CapgeminiApp.DataAccessLayer
{
    public class CustomerDbContext : DbContext
    {       
        public DbSet<CustomerModel> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CapgeminiApp;Integrated Security=True;Pooling=False");
        }
    }
}
