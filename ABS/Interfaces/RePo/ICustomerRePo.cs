using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces.RePo
{
    public interface ICustomerRePo
    {

        public Models.ICustomerModel CreateCustomer(string firstname, string lastname, string phonenumber, string email);


        public Models.ICustomerModel GetCustomerById(int ID);

        public List<Models.ICustomerModel> GetAllCustomers();


        public bool UpdateCustomer(int id, string firstname, string lastname, string phonenumber, string mail);


        public bool DeleteCustomer(int Id);
    }
}
