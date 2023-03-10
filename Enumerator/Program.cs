using System;
using System.Collections;

namespace Emuner
{
    class Program
    {
        public static void Main()
        {
            Garage garage = new Garage();
            garage.cars[0] = new Car("Q");
            garage.cars[1] = new Car("A");
            garage.cars[2] = new Car("B");
            garage.cars[3] = new Car("C");
            garage.cars[4] = new Car("W");
            garage.cars[5] = new Car("N");
            garage.cars[6] = new Car("Z");
            garage.cars[7] = new Car("X");
            garage.cars[8] = new Car("V");
            garage.cars[9] = new Car("M");

            foreach(Car car in garage)
            {
                Console.WriteLine(car.Name);
            }

        }
    }

    class Garage : IEnumerator, IEnumerable
    {
        public Car[] cars = new Car[10];

        int ind = 0;
        public object Current => cars[ind];

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if (ind < cars.Length)
            {
                ind++;
                return true;
            }
            else
                return false;
            
        }

        public void Reset()
        {
            ind = 0;
        }
    }

    class Car
    {
        public string Name { get; set; }
        public Car(string name)
        {
            Name = name;
        }
    }
}
