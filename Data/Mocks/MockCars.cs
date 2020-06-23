using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Data.Interfaces;
using TestShop.Data.Models;

namespace TestShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla_Model_S",
                        shortDesc = "Экономный и быстрый",
                        longDesc = "Прекрасный автомобиль",
                        img ="/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategorys.First()
                    },
                    new Car{
                        name = "Audi_R8",
                        shortDesc = "Красивый и спортивный",
                        longDesc = "Автомобиль для души",
                        img ="/img/audi.jpg",
                        price = 35000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategorys.Last()
                    },
                    new Car{
                        name = "Mercedes_Maybach",
                        shortDesc = "Современный и уютный",
                        longDesc = "Отчетливо подчеркивает ваш статус",
                        img ="/img/merc.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = false,
                        Category = _categoryCars.AllCategorys.Last()
                    },
                    new Car{
                        name = "Volkswagen_Passat",
                        shortDesc = "Элегантный и минималистичный",
                        longDesc = "Прекрасный выбор для частой езды",
                        img ="/img/volkswagen.jpg",
                        price = 9000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategorys.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
