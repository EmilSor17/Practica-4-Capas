using Domain_Repository.DTOs;
using Domain_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication_Repository
{
    public class ApplicationCars
    {
        public static List<CarDTO> ShowCars()
        {
            return Data_Repository.Car_Repository.CarRepository.ShowCars();
        }
        public static List<cbbNameDTO> cbb()
        {
            return Data_Repository.Car_Repository.CarRepository.cbbnameclient();
        }
        public static bool DisableCar (int id)
        {
            return Data_Repository.Car_Repository.CarRepository.DisableCar(id);
        }
        public static bool AddCar(ECar car)
        {
            return Data_Repository.Car_Repository.CarRepository.AddCar(car);
        }
        public static bool EnableCar(int id)
        {
            return Data_Repository.Car_Repository.CarRepository.EnableCar(id);
        }
    }
}
