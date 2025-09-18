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
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //Book book1 = new Book();
            //book1.PrintInfo();
            //Book book2 = new Book("Война и мир", "Толстой", 1869, true);
            //book2.PrintInfo();
        }
    }
}
