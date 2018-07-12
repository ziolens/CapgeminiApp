namespace CapgeminiApp.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using Models;

    public interface ICustomersManager
    {
        void CreateCustomer(CustomerModel model);
        void UpdateCustomer(CustomerModel model);
        void RemoveCustomer(CustomerModel model);
        IEnumerable<CustomerModel> GetAllCustomers();
        CustomerModel GetCustomerByID(Guid ID);
    }
}
