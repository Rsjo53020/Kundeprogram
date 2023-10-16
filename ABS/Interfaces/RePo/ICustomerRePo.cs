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


        public  Task<bool> CreateCustomerAsync(string firstname, string lastname, string phonenumber, string email);


        public Task<Models.ICustomerModel> GetCustomerByIdAsync(int ID);

        public Task<List<Models.ICustomerModel>> GetAllCustomersAsync();


        public Task<bool> UpdateCustomerAsync(int id, string firstname, string lastname, string phonenumber, string mail);


        public Task<bool> DeleteCustomerAsync(int Id);
    }
}
