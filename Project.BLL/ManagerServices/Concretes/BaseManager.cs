using Microsoft.EntityFrameworkCore.Diagnostics;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.ContextClasses;
using Project.DAL.Extensions;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class BaseManager<T> : IManager<T> where T : Vehicle
    {
        protected readonly VehicleDatabaseContext _db;

        public BaseManager(VehicleDatabaseContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = _db.Set<T>().Find(id);
            value.Status = ENTITIES.Enums.DataStatus.Deleted;
            value.DeletedDate = DateTime.UtcNow;
            _db.SaveChanges();
        }

        public void Destroy(int id)
        {
            var value=_db.Set<T>().Find(id);
            _db.Set<T>().Remove(value);
            _db.SaveChanges();
        }

        public List<T> GetActives()
        {
            return _db.Set<T>().Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetbyColor(VehicleColor color)
        {
            return _db.Set<T>().Where(x => x.Color==color).ToList();
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
        }
    }
}
