using CapgeminiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapgeminiApp
{
    public interface ICustomersManager
    {
        void CreateCustomer(CustomerModel model);
        void UpdateCustomer(CustomerModel model);
        void RemoveCustomer(CustomerModel model);
        IEnumerable<CustomerModel> GetAllCustomers();
        CustomerModel GetCustomerByID(Guid ID);
        void RemoveCustomer(Guid id);
    }
}
