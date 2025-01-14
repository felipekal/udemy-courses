using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTech.Entities.Enums
{
    public enum OrderStatus : int
    {
        Pending_Payment = 0, Processing = 1 , Shipeed = 2 , Delivered = 3
    }
}
