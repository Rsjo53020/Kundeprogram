using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces.Services
{
    public interface IAdressService
    {
        public void GetAllAdresses();
        public void GetAdressByZipCode(int zipCode);
        public void AddAdress(Adress adress);
        public void UpdateAdress(Adress adress);
        public void DeleteAdress(int zipCode);

    }
}
