using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Trip
    {
        public Driver Driver;
        public Car Car;
        public DateTime TripDate;
        public DateTime StartDate;
        public DateTime EndDate;

        public Trip(Driver driver, Car car, DateTime startTime, DateTime endTime)
        {
            this.Driver = driver;
            this.Car = car;
            this.StartDate = startTime;
            this.EndDate = endTime;
        }
        public void DispalayTripInfo()
        {
            Console.WriteLine($"Водитель - {Driver.Name}. Дата поездки - {TripDate}. Продолжительность поездки - {EndDate-StartDate}. Тип автомобиля - {Car.FuelOfType}");
        }
    }
}
