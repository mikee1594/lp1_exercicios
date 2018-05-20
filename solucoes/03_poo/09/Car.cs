using System;

namespace LP1Exercises
{
    public enum FuelType { Gasoline, Diesel, LPG, Electric };

    public class Car
    {

        private float speed;
        private float weight;
        private FuelType fuel;
        private static float maxSpeed = 220.0F;

        public Car(float weight, FuelType fuel)
        {
            this.weight = weight;
            this.fuel = fuel;
            speed = 0;
        }

        public float Accelerate(float x)
        {
            Console.WriteLine($"\tAccelerating {x}");

            speed += x;

            if (speed > maxSpeed)
            {
                Console.WriteLine($"\t\tHitted Max Speed ({maxSpeed}), accelerated {x - (speed - maxSpeed)}");
                speed = maxSpeed;
            }
            return speed;
        }

        public float Break(float x)
        {
            Console.WriteLine($"\tBreaking {x}");

            speed -= x;

            if (speed < 0)
            {
                Console.WriteLine($"\t\tHitted Full Stop (0), breaked {speed + x}");
                speed = 0;
            }
            return speed;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public FuelType GetFuelType()
        {
            return fuel;
        }

        public float GetWeight()
        {
            return weight;
        }

        public static float GetMaxSpeed()
        {
            return maxSpeed;
        }

        public static void SetMaxSpeed(float maxSpeed)
        {
            Car.maxSpeed = maxSpeed;
        }
    }
}
