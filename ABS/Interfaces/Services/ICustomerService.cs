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
        public List<Models.ICustomerModel> GetAllCustomers();

        public Models.ICustomerModel GetCustomerById(int id);

        public bool AddCustomer(string FirstName, string LastName, string PhoneNr, string Mail);
        

        public bool UpdateCustomer(int Id, string FirstName, string LastName, string PhoneNr, string Mail);

        public bool DeleteCustomer(int id);
    }
}
