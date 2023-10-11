using ABS.Interfaces.Models;
using ABS.Interfaces.RePo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BusinessCustomerService : BaseCustomerService

    {
        public BusinessCustomerService(ICustomerRePo customerRePo) : base(customerRePo)
        {
        }
    }
}
