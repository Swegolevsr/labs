using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Fleet
    {
        public List<Car> Cars;
        public List<Driver> Drivers;
        public List<Trip> Trips;

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void RegisterDriver(Driver driver)
        {
            driver.MedicalCertificate = new MedicalCertificate();
            Drivers.Add(driver);
        }
        public void CreateTrip(Driver driver, Car car, DateTime startTime, DateTime endTime)
        {
            Trips.Add(new Trip(driver, car, startTime, endTime));
        }
        public void DisplayTripsByDate(DateTime date)
        {
            foreach (Trip trip in Trips)
            {
                if (trip.TripDate == date)
                {
                    trip.DispalayTripInfo();
                }
            }
        }

        ~Fleet() 
        {
            for (int i = 0; i < Cars.Count; i++) 
            {
                Cars[i] = null;
            }
        }
    }
}
