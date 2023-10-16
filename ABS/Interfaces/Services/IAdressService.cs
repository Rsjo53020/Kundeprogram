using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces.Services
{
    public interface IAdressService
    {
        public Task<List<IAdressModel>> GetAllAdressesAsync();
        public Task<Models.IAdressModel> GetCustomerAdressAsync();
        public void GetAdressByZipCodeAsync(int zipCode);
        public void AddAdressAsync(IAdressModel adress);

    }
}
