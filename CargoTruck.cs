using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class CargoTruck : Car
    {
        private int cargo; //грузоподъемность
        private string type; //тип кузова

        public int Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public CargoTruck(int speed, string name, int weight, int power, int cargo, string type) : base(speed, name, weight, power)
        {
            Cargo = cargo;
            Type = type;
        }

        // Перегружаем метод преобразования класса в строку
        public override string ToString()
        {
            return "Name: " + Name + ", Weight: " + Weight + " , Speed " + Speed + " ,Power: " + Power + " ,Cargo: " + Cargo + " ,Type: " + Type;
        }

        public void load()
        {
            Console.WriteLine(Name + " loading..");
        }
        public void unload()
        {
            Console.WriteLine(Name + " unloading..");
        }
    }
}
