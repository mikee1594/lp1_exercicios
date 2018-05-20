using System;

namespace LP1Exercises
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
            Car.SetMaxSpeed(300);
            Console.WriteLine($"Car Max Speed: {Car.GetMaxSpeed()}");
            car.Accelerate(500);
        }
    }
}
