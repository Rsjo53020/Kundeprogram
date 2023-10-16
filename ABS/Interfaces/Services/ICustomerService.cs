using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces.Services
{
    public interface ICustomerService
    {
        public Task<List<Models.ICustomerModel>> GetAllCustomersAsync();

        public Task<Models.ICustomerModel> GetCustomerByIdAsync(int id);

        public Task<bool> AddCustomerAsync(string FirstName, string LastName, string PhoneNr, string Mail);
        

        public Task<bool> UpdateCustomerAsync(int Id, string FirstName, string LastName, string PhoneNr, string Mail);

        public Task<bool> DeleteCustomerAsync(int id);
    }
}
