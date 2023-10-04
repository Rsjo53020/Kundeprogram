using ABS.Interfaces.Models;
using ABS.Interfaces.RePo;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RePo.MockRePo
{
    public class CustomerMockRePo : ICustomerRePo

    {
        private readonly List<ABS.Interfaces.Models.ICustomerModel> _customers;

        List<ABS.Interfaces.Models.ICustomerModel> customers =
            Builder<ABS.Interfaces.Models.ICustomerModel>
                .CreateListOfSize(100)
                .Build()
                .ToList();

        /// <summary>
        /// (C)RUD
        /// </summary>
        /// <param name="customer"></param>
        public ICustomerModel CreateCustomer(string firstname, string lastname, string phonenumber, string email)
        {
           RePo.ModelsRePo.Customer customer = new RePo.ModelsRePo.Customer();
            customer.FirstName = firstname;
            customer.LastName = lastname;
            customer.Email = email;
            customer.Phonenumber = phonenumber;
            customer.Id = _customers.Count + 1;
            _customers.Add((ICustomerModel)customer);
            return (ICustomerModel)customer;
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
            return customers.Remove(customers.Where(x => x.Id == ID).
                First());         
        }

        public void CreateCustomer(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
