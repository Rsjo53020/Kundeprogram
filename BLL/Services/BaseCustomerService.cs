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
        public virtual void AddCustomer(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(int Id, string FirstName, string LastName, string PhoneNr, string Mail)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public virtual List<ICustomerModel> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public virtual void GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void UpdateCustomer(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
