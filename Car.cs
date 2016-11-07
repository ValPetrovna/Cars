using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        private int speed; //скорость
        private string name; //модель
        private int weight; //масса
        private int power; //мощность

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public int Power
        {
            get
            {
                return power;
            }

            set
            {
                power = value;
            }
        }
        public Car(int speed, string name, int weight, int power)
        {
            Speed = speed;
            Name = name;
            Weight = weight;
            Power = power;

        }

        public void startEngine()
        {
        }
        public void stopEngine()
        {
        }
        public void acceleration()
        {
        }
        public void brake()
        {
        }

        // Перегружаем метод преобразования класса в строку
        public override string ToString()
        {
            return "Name: " + Name + ", Weight: " + Weight + " , Speed " + Speed + " ,Power: " + Power;
        }


    }
}
