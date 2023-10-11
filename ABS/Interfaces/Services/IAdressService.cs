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
        public Models.IAdressModel GetCustomerAdress();
        public void GetAdressByZipCode(int zipCode);
        public void AddAdress(IAdressModel adress);

    }
}
