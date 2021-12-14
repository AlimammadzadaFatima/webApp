using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController:Controller
    {
        private List<Car> _cars;
        public CarController()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,Brand="Mercedes",Name="E200",Color="Red"},
                 new Car{Id=2,Brand="BMW",Name="B001",Color="Black"},
                  new Car{Id=3,Brand="Toyota",Name="T150",Color="Red"},
                   new Car{Id=4,Brand="Ferrari",Name="F777",Color="Yellow"},
                    new Car{Id=5,Brand="Hunday",Name="H250",Color="White"}

            };

        }


        public ActionResult Index()
        {
            ViewBag.Car = _cars;
            return View();
            
        }

        public ActionResult Detail(int id)
        {
            Car cr = _cars.FirstOrDefault(x => x.Id == id);
            ViewBag.Car = cr;
            return View();

        }
    }
}
