using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapgeminiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CapgeminiApp.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomersManager _manager;

        public CustomerController(ICustomersManager manager)
        {
            _manager = manager;
        }

        public IActionResult ManageCustomers()
        {
            var customers = _manager.GetAllCustomers();
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Update(CustomerModel model)
        {
            var customer = _manager.GetCustomerByID(model.ID);
            return View(customer);
        }

        public IActionResult Remove()
        {
            return View();
        }

        [HttpPost]
        public void CreateCustomer(CustomerModel model)
        {
            _manager.CreateCustomer(model);
            ManageCustomers();
        }

        [HttpPost]
        public void UpdateCustomer(CustomerModel model)
        {
            _manager.UpdateCustomer(model);
            ManageCustomers();
        }

        [HttpPost]
        public void RemoveCustomer(CustomerModel model)
        {
            _manager.RemoveCustomer(model);
            ManageCustomers();
        }
    }
}