using ABS.Interfaces.Models;
using ABS.Interfaces.RePo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PrivatCustomerService : BaseCustomerService
    {
        public PrivatCustomerService(ICustomerRePo customerRePo) : base(customerRePo)
        {
        }
    }
}
