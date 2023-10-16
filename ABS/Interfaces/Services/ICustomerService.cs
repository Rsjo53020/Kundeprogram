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
        public List<Models.ICustomerModel> GetAllCustomersAsync();

        public Models.ICustomerModel GetCustomerByIdAsync(int id);

        public bool AddCustomerAsync(string FirstName, string LastName, string PhoneNr, string Mail);
        

        public bool UpdateCustomerAsync(int Id, string FirstName, string LastName, string PhoneNr, string Mail);

        public bool DeleteCustomerAsync(int id);
    }
}
