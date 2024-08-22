using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Car : Vehicle
    {
        public byte Wheels { get; set; }
        public bool HeadLight { get; set; }
    }
}
