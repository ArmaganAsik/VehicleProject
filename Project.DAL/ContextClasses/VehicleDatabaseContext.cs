using Microsoft.EntityFrameworkCore;
using Project.DAL.Extensions;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class VehicleDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS ; Database=VehicleDB ; Trusted_Connection=True ; MultipleActiveResultSets=True ; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            CarDataSeedExtension.SeedCars(modelBuilder);
            BusDataSeedExtension.SeedBuses(modelBuilder);
            BoatDataSeedExtension.SeedBoats(modelBuilder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }
    }
}
