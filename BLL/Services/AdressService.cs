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
        public void AddAdress(IAdressModel adress)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdress(int zipCode)
        {
            throw new NotImplementedException();
        }

        public void GetAdressByZipCode(int zipCode)
        {
            throw new NotImplementedException();
        }

        public List<IAdressModel> GetAllAdresses()
        {
            throw new NotImplementedException();
        }

        public void GetCustomerAdress(ICustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdress(IAdressModel adress)
        {
            throw new NotImplementedException();
        }
    }
}
