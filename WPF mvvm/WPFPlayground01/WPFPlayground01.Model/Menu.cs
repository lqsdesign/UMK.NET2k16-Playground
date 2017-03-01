using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPlayground01.Model
{
    public class Menu
    {
        public List<Meal> MenuList { get; private set; }

        public Menu()
        {
            MenuList = new List<Meal>
            {
                new Meal()
                {
                    Id = 1,
                    Name = "Pizza 1",
                    Type = "Pizza",
                    Description = "Super pizza nr1",
                    Price = 14.50m
                },
                new Meal()
                {
                    Id = 2,
                    Name = "Pizza 2",
                    Type = "Pizza",
                    Description = "Zwykła pizza nr2",
                    Price = 12
                },
                new Meal()
                {
                    Id = 3,
                    Name = "Pizza 3",
                    Type = "Pizza",
                    Description = "Zwykła duża pizza nr3",
                    Price = 18.80m
                },
                new Meal()
                {
                    Id = 4,
                    Name = "Burger nr1",
                    Type = "Burger",
                    Description = "Mały burger",
                    Price = 12.20m
                },
                new Meal()
                {
                    Id = 5,
                    Name = "Burger nr2",
                    Type = "Burger",
                    Description = "Wielki burger",
                    Price = 16.20m
                },
                new Meal()
                {
                    Id = 6,
                    Name = "Pepsi",
                    Type = "Drink",
                    Description = "Pepsi w puszce",
                    Price = 3.50m
                }
            };
        }
    }
}
