using System;
using System.Collections.Generic;

namespace NullObject.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            WriteCarInformation(car);

            car.Engine = new Engine();

            WriteCarInformation(car);

            car.Engine = new Engine
            {
                SparkPlug = new List<SparkPlug>()
            };

            WriteCarInformation(car);

        }

        static void WriteCarInformation(Car car)
        {
            Console.WriteLine(car.Engine.IsEmpty());
            Console.WriteLine(car.Engine.SparkPlug.IsEmpty());
        }
    }
}
