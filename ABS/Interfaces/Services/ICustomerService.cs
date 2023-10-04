using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces.Services
{
    public interface ICustomerService
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public IAdressModel IAdressModel { get; set; }
    }
}
