using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdressService : ABS.Interfaces.Services.IAdressService
    {
        public void AddAdressAsync(IAdressModel adress)
        {
            throw new NotImplementedException();
        }

        public void GetAdressByZipCodeAsync(int zipCode)
        {
            throw new NotImplementedException();
        }

        public Task<List<IAdressModel>> GetAllAdressesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IAdressModel> GetCustomerAdressAsync()
        {
            throw new NotImplementedException();
        }
    }
}
