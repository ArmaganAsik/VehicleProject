using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class BusDataSeedExtension
    {
        public static void SeedBuses(ModelBuilder modelBuilder)
        {
            List<Bus> buses = new List<Bus>();
            buses.Add(new Bus { Name = "Neoplan", ID = 1, Color = ENTITIES.Enums.VehicleColor.White });
            buses.Add(new Bus { Name = "Man", ID = 2, Color = ENTITIES.Enums.VehicleColor.Blue });
            buses.Add(new Bus { Name = "Tourismo", ID = 3, Color = ENTITIES.Enums.VehicleColor.Red });
            buses.Add(new Bus { Name = "Travego", ID = 4, Color = ENTITIES.Enums.VehicleColor.Black });
            buses.Add(new Bus { Name = "Maraton", ID = 5, Color = ENTITIES.Enums.VehicleColor.Blue });
            buses.Add(new Bus { Name = "Safir", ID = 6, Color = ENTITIES.Enums.VehicleColor.Red });

            modelBuilder.Entity<Bus>().HasData(buses);
        }
    }
}
