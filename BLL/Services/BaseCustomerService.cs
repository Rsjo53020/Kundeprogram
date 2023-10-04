using ABS.Interfaces.Models;
using ABS.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BaseCustomerService : ICustomerService
    {
        public void AddCustomer(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
