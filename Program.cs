using System;

namespace Laba_7_Alecseev_ISP_232_ISRPO
{
    class Book
    {
        public string Title;
        public string Author;
        public int Year;
        public bool IsAvailable;
        public Book()
        {
            Title = "неизвестно";
            Author = "неизвестно";
            Year = 0;
            IsAvailable = false;
        }
        public Book(string title, string author, int year, bool IsAvailable)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.IsAvailable = IsAvailable;
        }

        public void PrintInfo()
        {
            string b = IsAvailable ? "Да" : "Нет";

            Console.WriteLine($"Название: \"{Title}\", Автор: {Author}, Год: {Year}, Доступна: {b}");
        }
    }

    class BankAccount
    {
        public string AccountNumber = "0000 0000 0000 0000";
        private decimal Balance = 0m;

        public void Deposit(decimal amount) { if (this.Balance >= 0) { this.Balance += amount; } }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount < this.Balance)
            {
                this.Balance -= amount;
            }
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Текущий баланс: {this.Balance} P");
        }
    }

    class Car
    {
        public string model;
        public int speed;
        public int maxSpeed;

        public Car(string model, int maxSpeed)
        {
            this.model = model;
            this.maxSpeed = maxSpeed;
            this.speed = 0;

        }

        public void Accelerate(int delta)
        {
            if (this.speed + delta <= maxSpeed)
            {
                this.speed += delta;
                Console.WriteLine($"Модель: {this.model}. Текущая скорость {this.speed}");
            }
            else
            {
                Console.WriteLine("Мощности не хватит.");
            }
        }

        public void Brake() { this.speed = 0; Console.WriteLine($"После торможения скорость {this.speed}"); }
    }
    
    class Dice 
    {
        private int _sides;

        public Dice(int sides = 6)
        {
            this._sides = sides;

        }

        public void Roll()
        {
            Random random = new Random();
            Console.WriteLine($"{_sides}-гранный кубик: {random.Next(1, _sides + 1)},{random.Next(1, _sides + 1)},{random.Next(1, _sides + 1)}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //Book book1 = new Book();
            //book1.PrintInfo();
            //Book book2 = new Book("Война и мир", "Толстой", 1869, true);
            //book2.PrintInfo();

            // Задание 2
            //BankAccount schot1 = new BankAccount();
            //schot1.Deposit(1000);
            //schot1.Withdraw(500);
            //schot1.PrintBalance();

            // Задание 3
            //Car car1 = new Car("Tesla Model S", 120);
            //car1.Accelerate(100);
            //car1.Accelerate(20);
            //car1.Brake();

            // Задание 4
            //Dice kub1 = new Dice();
            //Dice kub2 = new Dice(12);
            //kub1.Roll();
            //kub2.Roll();
        }
    }
}
