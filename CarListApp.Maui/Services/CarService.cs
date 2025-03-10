using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListApp.Maui.Models;

namespace CarListApp.Maui.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>() { 
                new Car
                {
                    Id = 1 , Make = "Honda" , Model = "Fit", Vin="1234"
                },
                new Car
                {
                    Id = 2 , Make = "Honda1" , Model = "Fit", Vin="12345"
                },
                new Car
                {
                    Id = 3 , Make = "Honda3" , Model = "Fit", Vin="12346"
                }
            };
        }
    }
}
