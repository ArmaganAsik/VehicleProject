using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstracts
{
    public interface IManager<T> where T : Vehicle
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Destroy(int id);
        List<T> GetbyColor(VehicleColor color);
        List<T> GetAll();
        List<T> GetActives();
    }
}
