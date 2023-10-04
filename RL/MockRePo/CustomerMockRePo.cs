using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RePo.MockRePo
{
    public class CustomerMockRePo
    {
        List<ABS.Interfaces.Models.ICustomerModel> customers =
            new List<ABS.Interfaces.Models.ICustomerModel>();

        /// <summary>
        /// (C)RUD
        /// </summary>
        /// <param name="customer"></param>
        public void CreateCustomer(ABS.Interfaces.Models.ICustomerModel customer)
        {
            customers.Add(customer);
        }

        /// <summary>
        /// C(R)UD
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ABS.Interfaces.Models.ICustomerModel GetCustomer(int ID)
        {
            return customers.where;
        }
        /// <summary>
        /// C(R)UD
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<ABS.Interfaces.Models.ICustomerModel> GetAllCustomers()
        {
            return customers;
        }

        /// <summary>
        /// CR(U)D
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public void UpdateCustomer(int ID)
        {

        }

        /// <summary>
        /// CRU(D)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteCustomer(int ID)
        {
            return true;
        }
    }
}
