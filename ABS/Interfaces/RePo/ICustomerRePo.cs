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
        List<Models.ICustomerModel>;
        public void CreateCustomer(Models.ICustomerModel customer);


        public Models.ICustomerModel GetCustomer(int ID);

        public List<Models.ICustomerModel> GetAllCustomers();


        public bool UpdateCustomer(Models.ICustomerModel customer);


        public bool DeleteCustomer(int ID);
    }
}
