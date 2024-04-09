using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
        class Program
        {
            static void Main(string[] args)
            {
                Motorcycle motorcycle = new Motorcycle(108);
                Bicycle bicycle = new Bicycle(15);
                Moped moped = new Moped(50);
                Car car = new Car(80, 4); 
                Train train = new Train(130, 20);
                TwoWheeled Elscooter = new TwoWheeled(30);

                motorcycle.DisplayInfo();
                Console.WriteLine();
                bicycle.DisplayInfo();
                Console.WriteLine();
                moped.DisplayInfo();
                Console.WriteLine();
                car.OpenDoors();
                car.DisplayInfo();
                Console.WriteLine();
                train.DisplayInfo();
                Console.WriteLine();
                Elscooter.DisplayInfo();
            }
        }
    }
    

