using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Stydent
    {
        public string name;
        public int age;
        public string group;
        public void PrintInfo()
        {
            Console.WriteLine($"Имя : {name}, " +
                $"Возраст : {age}, " +
                $"Группа : {group}");
        }
        public bool TsAdult()
        {
            return age >= 18;
        }
        public Stydent() { name = "Неизвестно"; age = 18; group = "Неизвестно"; }

        public Stydent(string yorName) { name = yorName; age = 18; group = "Неизвестно"; }

        public Stydent(string yorName, int yourAge) { name = yorName; age = yourAge; group = "Неизвестно"; }

        public Stydent(string yorName, int yourAge, string yourGroup) { name = yorName; age = yourAge; group = yourGroup; }

    }
}
