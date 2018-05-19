using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    public enum FuelType { Gasoline, Diesel, LPG, Electric };

    public class Car
    {

        public float Speed { get; private set; }
        public float Weight { get; private set; }
        public FuelType Fuel { get; private set; }
        public static float MaxSpeed = 220.0F;

        public Car(float weight, FuelType fuel)
        {
            Weight = weight;
            Fuel = fuel;
            Speed = 0;
        }

        public float Accelerate(float x)
        {
            Console.WriteLine($"\tAccelerating {x}");

            Speed += x;

            if (Speed > MaxSpeed)
            {
                Console.WriteLine($"\t\tHitted Max Speed ({MaxSpeed}), accelerated {x - (Speed - MaxSpeed)}");
                Speed = MaxSpeed;
            }
            return Speed;
        }

        public float Break(float x)
        {
            Console.WriteLine($"\tBreaking {x}");

            Speed -= x;

            if (Speed < 0)
            {
                Console.WriteLine($"\t\tHitted Full Stop (0), breaked {Speed + x}");
                Speed = 0;
            }
            return Speed;
        }

        public float GetSpeed()
        {
            return Speed;
        }

        public FuelType GetFuelType()
        {
            return Fuel;
        }

        public float GetWeight()
        {
            return Weight;
        }

        public static float GetMaxSpeed()
        {
            return MaxSpeed;
        }

        public static float SetMaxSpeed(float maxSpeed)
        {
            MaxSpeed = maxSpeed;

            return maxSpeed;
        }
    }
}
