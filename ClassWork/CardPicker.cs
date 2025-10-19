using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class CardPicker
    {
        private static Random random = new Random();

        public string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }

            return pickedCards;
        }

        private string RandomValue()
        {
            int value = random.Next(1, 14); // от 1 до 13 включительно

            return value switch
            {
                1 => "Туз",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                _ => value.ToString()
            };
        }

        private string RandomSuit()
        {
            string[] suits = { "червей", "бубен", "треф", "пик" };
            int index = random.Next(0, suits.Length);
            return suits[index];
        }
    }
}
