using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA123.Entities.Enums
{
    public enum OrderStatus : int
    {
        Pending_Payment,
        Processing,
        Shipper,
        Delivered
    }
}
