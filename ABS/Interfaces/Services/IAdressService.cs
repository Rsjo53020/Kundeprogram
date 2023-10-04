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
        public List<IAdressModel> GetAllAdresses();
        public GetCustomerAdress(ICustomerModel customer);
        public void GetAdressByZipCode(int zipCode);
        public void AddAdress(IAdressModel adress);
        public void UpdateAdress(IAdressModel adress);
        public void DeleteAdress(int zipCode);
    }
}
