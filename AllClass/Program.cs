using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AllClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage[0] = new Car(15, "Ab");
            garage[1] = new Car(16, "Bc");
            garage[2] = new Car(4, "123");
            garage[3] = new Car(2);
            garage[4] = new Car(90);

            garage[0].CarInfo.Message = "MESS!";
            Car car = (Car)garage[0].Clone();
            Console.WriteLine($"{car.Name} {car.CarInfo.Id} {car.CarInfo.Message}");

            garage.Sort();
            foreach(Car car1 in garage)
            {
                Console.WriteLine($"{car1.Name} {car1.CarInfo.Id} {car1.CarInfo.Message}");
            }
        }
    }

    public class Car : ICloneable, IComparable
    {
        public CarInfo CarInfo { get; set; }
        public string Name { get; set; } 

        public Car(int carInfoId, string name)
        {
            CarInfo = new CarInfo(carInfoId);
            Name = name;
        }
        public Car(int carInfoId) : this(carInfoId, "Default Name")
        {

        }

        public object Clone()
        {
            Car temp = new Car(this.CarInfo.Id, Name);
            temp.CarInfo.Message = this.CarInfo.Message;
            return temp;
        }

        public int CompareTo(object? obj)
        {
            if(obj is Car c1)
            {
                if(CarInfo.Id == c1.CarInfo.Id)
                    return 0;
                if (CarInfo.Id < c1.CarInfo.Id)
                    return -1;
                return 1;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public class Garage : IEnumerable
    {
        public Car this[int index]
        {
            get { return carsArray[index]; }
            set { carsArray[index] = value; }
        }
        private Car[] carsArray = new Car[5];

        public IEnumerator GetEnumerator()
        {
            return carsArray.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(carsArray);
        }
    }

    public class CarInfo
    {
        public int Id { get; set; }
        public string Message { get; set; }

        public CarInfo(int id, string message)
        {
            Id = id;
            Message = message;
        }
        public CarInfo(int id) : this(id,"Default message")
        {

        } 
    }
}