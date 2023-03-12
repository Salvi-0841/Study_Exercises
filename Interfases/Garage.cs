using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    internal class Garage : IEnumerable<Car>
    {
        private List<Car> cars;
        public Car this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }
        public int Count => cars.Count;
        public void Add(Car value)
        {
            cars.Add(value);
        }
        public void RemoveAt(int index)
        {
            cars.RemoveAt(index);
        }
        public void Remove(Car value)
        {
            cars.Remove(value);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }
}
