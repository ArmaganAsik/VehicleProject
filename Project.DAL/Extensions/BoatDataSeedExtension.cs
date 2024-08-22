using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public static class BoatDataSeedExtension
    {
        public static void SeedBoats(ModelBuilder modelBuilder)
        {
            List<Boat> boats = new();
            boats.Add(new Boat { Name = "Azure", ID = 1, Color = ENTITIES.Enums.VehicleColor.White });
            boats.Add(new Boat { Name = "Bavaria ", ID = 2, Color = ENTITIES.Enums.VehicleColor.Black });
            boats.Add(new Boat { Name = "Jeanneau", ID = 3, Color = ENTITIES.Enums.VehicleColor.Blue });
            boats.Add(new Boat { Name = "J Boats", ID = 4, Color = ENTITIES.Enums.VehicleColor.Black });
            boats.Add(new Boat { Name = "Nautorswan", ID = 5, Color = ENTITIES.Enums.VehicleColor.Red });
            boats.Add(new Boat { Name = "Salona", ID = 6, Color = ENTITIES.Enums.VehicleColor.White });

            modelBuilder.Entity<Boat>().HasData(boats);
        }
    }
}
