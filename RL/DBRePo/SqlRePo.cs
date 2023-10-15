using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RePo.DBRePo
{
    public class SqlRePo : ABS.Interfaces.RePo.ICustomerRePo
    {
        public bool CreateCustomer(string firstname, string lastname, string phonenumber, string email)
        {
            using(CustomerDBRepoContext context = new CustomerDBRepoContext())
            {
                return context;
            }
        }

        public bool DeleteCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ICustomerModel> GetAllCustomers()
        {
            using(CustomerDBRepoContext context = new CustomerDBRepoContext()) 
            {
                return context.Customers.ToList<ICustomerModel>();
            }
        }

        public ICustomerModel GetCustomerById(int ID)
        {
            using(CustomerDBRepoContext context = new CustomerDBRepoContext())
            {
                return context.Customers.Where(x => x.Id == ID).FirstOrDefault();
            }
        }

        public bool UpdateCustomer(int id, string firstname, string lastname, string phonenumber, string mail)
        {
            throw new NotImplementedException();
        }
    }
}
