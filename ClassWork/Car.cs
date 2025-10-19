using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Car
    {
        public string model;
        private int currentSpeed;
        protected string engineType;

        public void Accelerate(int speed)
        {
            if (speed > 0)
            {
                currentSpeed = speed;
                Console.WriteLine($"Разгон до скорочти:{currentSpeed} км/ч");
            }
        }
        private void CheckEngine()
        {
            Console.WriteLine("Проверка двигателя");

        }
    }
}
