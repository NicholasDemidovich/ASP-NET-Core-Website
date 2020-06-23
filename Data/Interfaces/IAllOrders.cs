using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Data.Models;

namespace TestShop.Data.Interfaces
{
    public interface IAllOrders
    {
        void creatrOrder(Order order);
    }
}
