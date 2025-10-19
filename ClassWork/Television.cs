using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Television
    {
        private int volum = 100;
        public void SetVolum(int newVolume)
        {
            if (newVolume >= 0 && newVolume <= 100)
            {
                volum = newVolume;
                Console.WriteLine($"Громкость изменена {volum}");
            }
            else
            {
                Console.WriteLine("Ошибка! Громкость должна быть от 0 до 100.");
            }
        }
    }
}
