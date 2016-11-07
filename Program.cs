using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(95, "Niva", 1500, 80);
            Car car2 = new Car(215, "Mazda 6", 1600, 150);
            CargoTruck car3 = new CargoTruck(90, "Kamaz", 11500, 240, 13000, "Samosval");
            CargoTruck car4 = new CargoTruck(110, "MAN", 10000, 400, 50000, "Tyagach");

            Car a = car1;
            Car b = car3;
            Car c = car2;
            Car d = car4;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
