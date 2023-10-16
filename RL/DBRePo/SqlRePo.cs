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
        public async Task<bool> CreateCustomerAsync(string firstname, string lastname, string phonenumber, string email)
        {
            var customer = new ModelsRePo.Customer();
            customer.FirstName = firstname;
            customer.LastName = lastname;
            customer.Phonenumber = phonenumber;
            customer.Email = email;

            await using(CustomerDBRepoContext context = new CustomerDBRepoContext())
            {
                context.Add(customer);
                context.SaveChanges();
                return true;
            }
        }

        public async Task<bool> DeleteCustomerAsync(int Id)
        {
            await using (CustomerDBRepoContext context = new CustomerDBRepoContext())
            {
                var customerToRemove = context.Customers.FirstOrDefault(x => x.Id == Id);
                if (customerToRemove != null)
                {
                    context.Customers.Remove(customerToRemove);
                    context.SaveChanges();
                }
            }
            return true;
        }

        public async Task<List<ICustomerModel>> GetAllCustomersAsync()
        {
            await using(CustomerDBRepoContext context = new CustomerDBRepoContext()) 
            {
                return context.Customers.ToList<ICustomerModel>();
            }
        }

        public async Task<ICustomerModel> GetCustomerByIdAsync(int ID)
        {
            await using(CustomerDBRepoContext context = new CustomerDBRepoContext())
            {
                return context.Customers.Where(x => x.Id == ID).FirstOrDefault();
            }
        }

        public async Task<bool> UpdateCustomerAsync(int id, string firstname, string lastname, string phonenumber, string mail)
        {
            await using (CustomerDBRepoContext context = new CustomerDBRepoContext())
            {
                var customerToUpdate = context.Customers.FirstOrDefault(x => x.Id == id);
                if (customerToUpdate != null)
                {
                    customerToUpdate.FirstName = firstname;
                    customerToUpdate.LastName = lastname;
                    customerToUpdate.Phonenumber = phonenumber;
                    customerToUpdate.Email = mail;
                    context.SaveChanges();
                }
            }
            return true;
        }
    }
}
