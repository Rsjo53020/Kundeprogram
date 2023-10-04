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
        private readonly ABS.Interfaces.RePo.ICustomerRePo _customerRePo;


        public ICustomerModel AddCustomer(int Id, string FirstName, string LastName, string PhoneNr, string Mail)
        {
            return _customerRePo.CreateCustomer(Id, FirstName, LastName, PhoneNr, Mail);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRePo.DeleteCustomer(id);
        }

        public List<ICustomerModel> GetAllCustomers()
        {
            return _customerRePo.GetAllCustomers();
        }

        public ICustomerModel GetCustomerById(int id)
        {
            return _customerRePo.GetCustomerById(id);
        }

        public bool UpdateCustomer(int Id, string FirstName, string LastName, string PhoneNr, string Mail)
        {
            return _customerRePo.UpdateCustomer(Id, FirstName, LastName, PhoneNr, Mail);
        }

    }

}
