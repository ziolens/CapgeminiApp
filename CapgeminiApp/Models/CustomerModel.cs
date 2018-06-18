using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapgeminiApp.Models
{
    public class CustomerModel
    {
        public CustomerModel()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
    }
}
