using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RePo.MockRePo
{
    public class CustomerMockRePo
    {
        List<ABS.Interfaces.Models.ICustomerModel> customers =
            Builder<ABS.Interfaces.Models.ICustomerModel>
                .CreateListOfSize(100)
                .Build()
                .ToList();

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
            return customers.Where(x=> x.Id == ID).FirstOrDefault();
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
        public bool UpdateCustomer(ABS.Interfaces.Models.ICustomerModel customer)
        {
            try
            {
                customers[customers.IndexOf(customers.Where(x => x.Id == customer.Id).
                FirstOrDefault())] = customer;
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
      
        }

        /// <summary>
        /// CRU(D)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteCustomer(int ID)
        {
            var customerToRemove = customers.FirstOrDefault(x => x.Id == ID);

            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove);
                return true;
            }

            return false;
        }
    }
}
