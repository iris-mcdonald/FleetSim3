using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FleetSim.Objects;//my class & interface folders are here

namespace FleetSim
{
    class Program
    {
        public static List<Car> LoadCars()
        {
            var theCars = new List<Car>
                {
                new Car()
                {
                    VIN = Guid.Empty,
                    Color = "white",
                    LastServicedMileage = 0,
                    LastServicedDate = "M/dd/yyyy h:mm:ss.fff.tt",
                    Mileage = 0,
                    Model = "Mazda CX5",
                    ModelYear = 2016,
                },
                new Car()
                {
                    VIN = Guid.Empty,
                    Color = "red",
                    LastServicedMileage = 0,
                    LastServicedDate = "M/dd/yyyy h:mm:ss.fff.tt",
                    Mileage = 0,
                    Model = "Honda CRV",
                    ModelYear = 2014
                },
                new Car()
                {
                    VIN = Guid.Empty,
                    Color = "blue",
                    LastServicedMileage = 0,
                    LastServicedDate = "M/dd/yyyy h:mm:ss.fff.tt",
                    Mileage = 0,
                    Model = "Jeep Wrangler",
                    ModelYear = 2010
                },
                new Car()
                {
                    VIN = Guid.Empty,
                    Color = "red",
                    LastServicedMileage = 0,
                    LastServicedDate = "M/dd/yyyy h:mm:ss.fff.tt",
                    Mileage = 0,
                    Model = "Alpha Romeo Stelvio",
                    ModelYear = 2018
                },
                new Car()
                {
                    VIN = Guid.Empty,
                    Color = "white",
                    LastServicedMileage = 0,
                    LastServicedDate = "M/dd/yyyy h:mm:ss.fff.tt",
                    Mileage = 0,
                    Model = "Ford F150",
                    ModelYear = 2004
                },
            };
            foreach (Car theCar in theCars)
            {
                Console.WriteLine(theCar.Model + " " + theCar.ModelYear);
            }
            return theCars;

        }

        public static int getRandomNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(5000, 15001);
            return randomNumber;
        }

        static void Main(string[] args)
        {
            List<Car> carList = LoadCars();//creates & loads list of Cars; and returns it

            byte i = 0;

            while (i < 10)
            {

                foreach (var car in carList)
                {
                    int miles = getRandomNumber();//generates a random # between 5000-15,000

                    car.Mileage += miles;

                }

                i++;
            }

            Console.ReadKey();


        }
    }
}
