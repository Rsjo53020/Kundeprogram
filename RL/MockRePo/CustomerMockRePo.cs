using ABS.Interfaces.Models;
using ABS.Interfaces.RePo;
using FizzWare.NBuilder;
using RePo.ModelsRePo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RePo.MockRePo
{
    public class CustomerMockRePo : ABS.Interfaces.RePo.ICustomerRePo

    {
        private readonly List<ABS.Interfaces.Models.ICustomerModel> _customers;
        public CustomerMockRePo()
        {
            //_customers =
            //Builder<ABS.Interfaces.Models.ICustomerModel>
            //    .CreateListOfSize(10)
            //    .Build()
            //    .ToList();

            _customers = new List<ICustomerModel>();

            _customers.Add(new ModelsRePo.Customer() { FirstName = "Ronni", LastName = "Jørgensen", Email = "RJ@ucl.dk", Phonenumber = "10203040", Id = 1 });
            _customers.Add(new ModelsRePo.Customer() { FirstName = "Christoffer", LastName = "Skaft", Email = "CS@ucl.dk", Phonenumber = "20203040", Id = 2 });
            _customers.Add(new ModelsRePo.Customer() { FirstName = "Alex", LastName = "Handsome", Email = "AH@ucl.dk", Phonenumber = "30203040", Id = 3 });
        }

        /// <summary>
        /// (C)RUD
        /// </summary>
        /// <param name="customer"></param>
        public bool CreateCustomer(string firstname, string lastname, string phonenumber, string email)
        {
            ModelsRePo.Customer customer = new ModelsRePo.Customer();
            customer.FirstName = firstname;
            customer.LastName = lastname;
            customer.Email = email;
            customer.Phonenumber = phonenumber;
            customer.Id = _customers.Count + 1;
            _customers.Add(customer);
            return true;
        }

        /// <summary>
        /// CRU(D)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteCustomer(int ID)
        {
            try
            {
                var DeletedACustomer = _customers.FirstOrDefault(x => x.Id == ID);
                if (DeletedACustomer != null)
                {
                    _customers.Remove(DeletedACustomer);
                    return true;
                }
                return false;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// C(R)UD
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<ICustomerModel> GetAllCustomers()
        {
            return _customers;

        }

        /// <summary>
        /// C(R)UD
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ICustomerModel GetCustomerById(int ID)
        {
            return _customers.FirstOrDefault(x => x.Id == ID);
        }

        /// <summary>
        /// CR(U)D
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool UpdateCustomer(int ID, string firstname, string lastname, string phonenumber, string mail)
        {
            try
            {
                int indexOfCustomer = _customers.IndexOf(_customers.FirstOrDefault(x => x.Id == ID));

                if (indexOfCustomer! > 0)
                {
                    _customers[indexOfCustomer].FirstName = firstname;
                    _customers[indexOfCustomer].LastName = lastname;
                    _customers[indexOfCustomer].Phonenumber = phonenumber;
                    _customers[indexOfCustomer].Email = mail;
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
