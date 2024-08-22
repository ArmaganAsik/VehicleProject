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
    public class CarManager : BaseManager<Car>, ICarManager
    {
        public CarManager(VehicleDatabaseContext db) : base(db)
        {
        }

        public Car TurnHeadLight(int id)
        {
            var value = _db.Set<Car>().Find(id);
            value.HeadLight = !value.HeadLight;
            _db.SaveChanges();
            return value;
        }
    }
}
