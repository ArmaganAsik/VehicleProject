using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        readonly ICarManager _carMan;
        readonly IBusManager _busMan;
        readonly IBoatManager _boatMan;

        public VehicleController(ICarManager carManager, IBusManager busManager, IBoatManager boatManager)
        {
            _carMan = carManager;
            _busMan = busManager;
            _boatMan = boatManager;
        }

        //GET ALL CARS
        [HttpGet("AllCars")]
        public List<Car> ListAllCars()
        {
            return _carMan.GetAll();
        }

        //GET CARS BY COLOR
        [HttpGet("CarsByColor")]
        public List<Car> ListCarsByColor([FromQuery] VehicleColor color)
        {
            return _carMan.GetbyColor(color);
        }

        //HEADLIGHTS ONOFF CAR
        [HttpPost("OnOffHeadlightsOfCar")]
        public Car HeadlightSwitch(int id)
        {
            return _carMan.TurnHeadLight(id);
        }

        //GET BUSES BY COLOR
        [HttpGet("BusesByColor")]
        public List<Bus> ListBusesByColor([FromQuery] VehicleColor color)
        {
            return _busMan.GetbyColor(color);
        }

        //GET BOATS BY COLOR
        [HttpGet("BoatsByColor")]
        public List<Boat> ListBoatsByColor([FromQuery] VehicleColor color)
        {
            return _boatMan.GetbyColor(color);
        }

        //DELETE CAR
        [HttpDelete("DeleteCar")]
        public List<Car> DeleteCar(int id)
        {
            _carMan.Delete(id);
            return _carMan.GetAll();
        }

        //DESTROY CAR
        [HttpDelete("DestroyCar")]
        public void DestroyCar(int id)
        {
            _carMan.Destroy(id);
        }

        //GET ACTIVE CARS
        [HttpGet("ActiveCars")]
        public List<Car> ListActiveCars()
        {
            return _carMan.GetActives();
        }

        //ADD CAR
        [HttpPost("AddCar")]
        public List<Car> AddCar(Car car)
        {
            _carMan.Add(car);
            return _carMan.GetActives();
        }

        //UPDATE CAR
        [HttpPut("UpdateCar")]
        public Car UpdateCar(Car car)
        {
            _carMan.Update(car);
            return car;
        }
    }
}
