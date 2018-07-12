namespace CapgeminiApp.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class CustomersManager : ICustomersManager
    {
        public void CreateCustomer(CustomerModel model)
        {
            using (var context = new CustomerDbContext())
            {
                model.ID = Guid.NewGuid();
                context.Customers.Add(model);
                context.SaveChanges();
            }
        }

        public void RemoveCustomer(CustomerModel model)
        {
            using (var context = new CustomerDbContext())
            {
                context.Customers.Remove(model);
                context.SaveChanges();
            }
        }

        public void UpdateCustomer(CustomerModel model)
        {
            using (var context = new CustomerDbContext())
            {
                context.Customers.Update(model);
                context.SaveChanges();
            }
        }

        public IEnumerable<CustomerModel> GetAllCustomers()
        {
            List<CustomerModel> customers;
            using (var context = new CustomerDbContext())
            {
                customers = context.Customers.ToList();
            }

            return customers;
        }

        public CustomerModel GetCustomerByID(Guid ID)
        {
            CustomerModel customerModel;
            using (var context = new CustomerDbContext())
            {
                customerModel = context.Customers.FirstOrDefault(c => c.ID == ID);
            }

            return customerModel;
        }
    }
}
