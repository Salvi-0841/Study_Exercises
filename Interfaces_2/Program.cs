using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Interfaces_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new();
            foreach(Car car in garage)
            {
                Console.WriteLine(car.Name);
            }
        }
    }
    public class Garage : IEnumerable, IEnumerator
    {
        public Car[] carArray = new Car[6];
        private int indexPosition = -1;
        public Garage()
        {
            carArray[0] = new Car("Ab");
            carArray[1] = new Car("Bb");
            carArray[2] = new Car("Ca");
            carArray[3] = new Car("Ca2");
            carArray[4] = new Car("Ca3");
            carArray[5] = new Car("Ca4");
        }

        public object Current
        {
            get 
            {
                    return carArray[indexPosition];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if(indexPosition >= carArray.Length - 1)
            {
                return false;
            }
            else
            {
                indexPosition++;
                return true;
            }
        }

        public void Reset()
        {
            indexPosition = -1;
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public Car(string name)
        {
            Name = name;
        }
    }
}