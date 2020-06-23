using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Data.Interfaces;
using TestShop.Data.Models;

namespace TestShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategorys
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
