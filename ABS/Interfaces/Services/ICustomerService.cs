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
        public List<ICustomerModel> GetAllCustomers();

        public void GetCustomerById(int id);

        public void AddCustomer(int Id, string FirstName, string LastName, string PhoneNr, string Mail);
        
        public void UpdateCustomer(ICustomerModel customer);

        public void DeleteCustomer(int id);
    }
}
