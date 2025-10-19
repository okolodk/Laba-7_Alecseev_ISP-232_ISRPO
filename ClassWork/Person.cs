using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Person
    {
        int age;
        public static int retirementAge = 65;
        public Person(int age)
        {
            this.age = age;

        }
        public void CheckAge()
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
        }
    }
}
