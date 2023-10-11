using ABS.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RePo.ModelsRePo
{
    public class Customer : ABS.Interfaces.Models.ICustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public IAdressModel Adress { get; set ; }
    }
}
