using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class Vehicle
    {
        protected Vehicle()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public VehicleColor Color { get; set; }
    }
}
