using System;
using System.ComponentModel.DataAnnotations;

namespace CapgeminiApp.Models
{
    public class CustomerModel
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address { get; set; }
    }
}
