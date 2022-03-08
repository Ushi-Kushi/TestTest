using System;

namespace FunnyTest
{
    class Cars<T>
    {
        public string Name { get; set; }
        public T SubName { get; set; }

        public Cars (string name, T subname)
            {
            Name = name;
            SubName = subname;
            }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cars<string> volvo = new Cars<string>("volvo", "XC");
            Cars<int> audi = new Cars<int>("audi", 100);

            Console.WriteLine(string.Format("{0} модель {1} ", volvo.Name, volvo.SubName));
            Console.WriteLine(string.Format("{0} модель {1} ", audi.Name, audi.SubName));
            int count = 0;
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            { Console.WriteLine("Enter"); count++; }
            Console.WriteLine("\t {0} TIMES!!! \n \t You're stupid", count);
                
                Environment.Exit(0) ;

        }
    }
}
