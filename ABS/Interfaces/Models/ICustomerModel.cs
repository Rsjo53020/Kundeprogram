using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces.Models
{
    public interface ICustomerModel
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phonenumber { get; set; }
        string Email { get; set; }
        
        IAdressModel Adress { get; set; }

        
    }
}


