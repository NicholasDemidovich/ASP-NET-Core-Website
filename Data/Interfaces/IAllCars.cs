using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Data.Models;

namespace TestShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars { get;}
        Car getObjectCar(int carID);
    }
}
