using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class CarDataSeedExtension
    {
        public static void SeedCars(ModelBuilder modelBuilder)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { Name = "BMW 320i", ID = 1, Color = ENTITIES.Enums.VehicleColor.Red, Wheels = 4, HeadLight = false });
            cars.Add(new Car { Name = "Citroen C3", ID = 2, Color = ENTITIES.Enums.VehicleColor.Red, Wheels = 4, HeadLight = false });
            cars.Add(new Car { Name = "Dacia Logan", ID = 3, Color = ENTITIES.Enums.VehicleColor.White, Wheels = 4, HeadLight = false });
            cars.Add(new Car { Name = "Fiat Egea", ID = 4, Color = ENTITIES.Enums.VehicleColor.White, Wheels = 4, HeadLight = false });
            cars.Add(new Car { Name = "Ford Focus", ID = 5, Color = ENTITIES.Enums.VehicleColor.White, Wheels = 4, HeadLight = false });
            cars.Add(new Car { Name = "Honda Civic", ID = 6, Color = ENTITIES.Enums.VehicleColor.Black, Wheels = 4, HeadLight = false });
            cars.Add(new Car { Name = "Mercedes CLA", ID = 7, Color = ENTITIES.Enums.VehicleColor.Blue, Wheels = 4, HeadLight = false });
            cars.Add(new Car { Name = "Opel Corsa", ID = 8, Color = ENTITIES.Enums.VehicleColor.Blue, Wheels = 4, HeadLight = false });

            modelBuilder.Entity<Car>().HasData(cars);
        }
    }
}
