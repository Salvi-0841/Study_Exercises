using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    internal class Car : IDrive
    {
        public string PetName { get; set; }
        public Guid ID { get; set; }

        public Car(string petName, Guid iD = new Guid())
        {
            PetName = petName;
            ID = iD;
        }

        public void ShowMe()
        {
            Console.WriteLine($"I'm {PetName} ID = {ID}");
        }

        public void TurnRight()
        {
            Console.WriteLine($"{PetName} TurnedRight");
        }

        public void TurnLeft()
        {
            Console.WriteLine($"{PetName} TurnedLeft");
        }

        IDrive IDrive.ReturnSelf()
        {
            return (IDrive)this;
        }
    }
}
