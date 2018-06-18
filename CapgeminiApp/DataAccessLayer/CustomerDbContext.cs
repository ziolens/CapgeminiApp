using CapgeminiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CapgeminiApp.DataAccessLayer
{
    public class CustomerDbContext : DbContext
    {       
        public DbSet<CustomerModel> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CapgeminiApp;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
