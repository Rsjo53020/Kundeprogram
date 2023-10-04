using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PrivatCustomerService : BaseCustomerService
    {
        public override void AddCustomer(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public override void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public override List<ICustomerModel> GetAllCustomers()
        {
            return base.GetAllCustomers();
        }

        {
            throw new NotImplementedException();
        }

        public override void GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public override void UpdateCustomer(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
