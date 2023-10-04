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
        public void GetAllCustomers();

        public void GetCustomerById(int id);

        public void AddCustomer(Customer customer);

        public void UpdateCustomer(Customer customer);

        public void DeleteCustomer(int id);


    }
}
