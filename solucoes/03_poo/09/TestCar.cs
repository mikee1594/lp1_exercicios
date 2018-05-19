using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class TestCar
    {
        static void Main(string[] args)
        {
            Car car = new Car(1000, FuelType.Gasoline);

            // Test GetFuelType, GetWeight , GetMaxSpeed
            Console.WriteLine($"Car Fuel: {car.GetFuelType()}");
            Console.WriteLine($"Car Weight: {car.GetWeight()}");
            Console.WriteLine($"Car Max Speed: {Car.GetMaxSpeed()}");
            Console.WriteLine();
            // Test Accelerate, Break and GetSpeed
            Console.WriteLine($"Speed: {car.GetSpeed()}");
            car.Accelerate(50);
            Console.WriteLine($"Speed: {car.GetSpeed()}");
            car.Accelerate(500);
            Console.WriteLine($"Speed: {car.GetSpeed()}");
            car.Break(50);
            Console.WriteLine($"Speed: {car.GetSpeed()}");
            car.Break(500);
            Console.WriteLine($"Speed: {car.GetSpeed()}");
            Console.WriteLine();
            // Test SetMaxSpeed
            Console.WriteLine($"Car Max Speed: {Car.SetMaxSpeed(300)}");
            car.Accelerate(500);
        }
    }
}
