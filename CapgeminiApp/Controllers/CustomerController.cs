using System;
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

        public IActionResult Update(Guid id)
        {
            var customer = _manager.GetCustomerByID(id);            
            return View(customer);
        }

        public IActionResult Remove(Guid id)
        {
            var customer = _manager.GetCustomerByID(id);
            return View(customer);       
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomerModel model)
        {
            _manager.CreateCustomer(model);
            var customers = _manager.GetAllCustomers();
            return View("ManageCustomers", customers);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(CustomerModel model)
        {
            _manager.UpdateCustomer(model);
            var customers = _manager.GetAllCustomers();
            return View("ManageCustomers", customers);
        }

        [HttpPost]
        public IActionResult RemoveCustomer(CustomerModel model)
        {
            _manager.RemoveCustomer(model);
            var customers = _manager.GetAllCustomers();
            return View("ManageCustomers", customers);
        }
    }
}