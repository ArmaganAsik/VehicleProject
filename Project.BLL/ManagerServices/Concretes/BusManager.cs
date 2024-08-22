using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class BusManager : BaseManager<Bus>, IBusManager
    {
        public BusManager(VehicleDatabaseContext db) : base(db)
        {
        }
    }
}
