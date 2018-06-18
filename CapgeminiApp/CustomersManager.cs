using CapgeminiApp.DataAccessLayer;
using CapgeminiApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CapgeminiApp
{
    public class CustomersManager : ICustomersManager
    {
        public void CreateCustomer(CustomerModel model)
        {
            using (var context = new CustomerDbContext())
            {
                var query = "INSERT INTO Customers (ID, Name, Surname, TelephoneNumber, Address) VALUES (@ID, @Name, @Surname, @TelephoneNumber, @Address)";
                var sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", model.ID),
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@Surname", model.Surname),
                    new SqlParameter("@TelephoneNumber", model.TelephoneNumber),
                    new SqlParameter("@Address", model.Address),
                };
                
                context.Database.ExecuteSqlCommand(query, sqlParameters);
            }
        }

        public void RemoveCustomer(CustomerModel model)
        {
            using (var context = new CustomerDbContext())
            {
                var query = "DELETE FROM Customers WHERE ID = @ID";
                var sqlParameter = new SqlParameter("@ID", model.ID);
                context.Database.ExecuteSqlCommand(query, sqlParameter);
            }
        }

        public void UpdateCustomer(CustomerModel model)
        {
            using (var context = new CustomerDbContext())
            {
                var query = "UPDATE Customers SET Name = @Name, Surname = @Surname, TelephoneNumber = @TelephoneNumber, Address = @Address WHERE ID = @ID";
                var sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", model.ID),
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@Surname", model.Surname),
                    new SqlParameter("@TelephoneNumber", model.TelephoneNumber),
                    new SqlParameter("@Address", model.Address),
                };

                context.Database.ExecuteSqlCommand(query, sqlParameters);
            }
        }

        public IEnumerable<CustomerModel> GetAllCustomers()
        {
            List<CustomerModel> customers;
            using (var context = new CustomerDbContext())
            {
                customers = context.Customers.FromSql("SELECT * FROM Customers").ToList();
            }

            return customers;
        }

        public CustomerModel GetCustomerByID(Guid ID)
        {
            CustomerModel customerModel;
            using (var context = new CustomerDbContext())
            {
                var query = "SELECT * FROM Customers WHERE ID = @ID";
                var sqlParameter = new SqlParameter("@ID", ID);
                customerModel = context.Customers.FromSql(query, sqlParameter).First();
            }

            return customerModel;
        }

        public void RemoveCustomer(Guid id)
        {
            using (var context = new CustomerDbContext())
            {
                var query = "DELETE FROM Customers WHERE ID = @ID";
                var sqlParameter = new SqlParameter("@ID", id);
                context.Database.ExecuteSqlCommand(query, sqlParameter);
            }
        }
    }
}
