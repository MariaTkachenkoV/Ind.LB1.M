using System;

namespace Ind.LB1.M
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое 
            Console.WriteLine("Задание №1");
            try
            {            
                Console.WriteLine("Введите год выпуска");
                int Year1 = int.Parse(Console.ReadLine()),
                    Year2 = int.Parse(Console.ReadLine()),
                    Year3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите имя автора");
                string Author1 = Console.ReadLine(),
                       Author2 = Console.ReadLine(),
                       Author3 = Console.ReadLine();
                Console.WriteLine("Введите название фильма");
                string Film1 = Console.ReadLine(),
                       Film2 = Console.ReadLine(),
                       Film3 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" __________________________________________________________________________________ ");
                Console.WriteLine("|{0,0}", "Кинопродукция                                                                     |");
                Console.WriteLine("|__________________________________________________________________________________|");
                Console.WriteLine("|{0,-30}|{1,-30}|{2,-15}|{3,-4}|", "Фильм", "Режиссер", "Год выпуска", "Тип");
                Console.WriteLine("|______________________________|______________________________|_______________|____|");
                Console.WriteLine("|{0,-30}|{1,-30}|{2,-15}|{3,-4}|", Film1, Author1, Year1, 'К');
                Console.WriteLine("|______________________________|______________________________|_______________|____|");
                Console.WriteLine("|{0,-30}|{1,-30}|{2,-15}|{3,-4}|", Film2, Author2, Year2, 'A');
                Console.WriteLine("|______________________________|______________________________|_______________|____|");
                Console.WriteLine("|{0,-30}|{1,-30}|{2,-15}|{3,-4}|", Film3, Author3, Year3, 'М');
                Console.WriteLine("|______________________________|______________________________|_______________|____|");
                Console.WriteLine("|{0,-100}", "Перечисляемый тип:Д - драма,К – комедия,М – мелодрама,Б – боевик, А – мультфильм  |");
                Console.WriteLine("|__________________________________________________________________________________|");
            }
                catch
                    {
                    Console.WriteLine("Error");
                    }
            //Второе
            Console.WriteLine("Задание №2");
            try
            {
                Console.WriteLine("Введите переменную х");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите перемнную m");
                double m = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите перемнную c");
                double с = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите перемнную a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите перемнную b");
                double b = double.Parse(Console.ReadLine());
                double z = (Math.Sin(x) / (Math.Sqrt(Math.Pow(m, 2) + Math.Pow(Math.Sin(x), 2)))) - (с * m *( Math.Log(m*x, Math.E)));
                if((Math.Pow(m, 2) + Math.Pow(Math.Sin(x), 2))<0)
                {
                    Console.WriteLine("Одно из значений не входит в ОДЗ");
                    Environment.Exit(0);
                }
                double s = (Math.Pow(Math.E, (-a * x)) * (Math.Sqrt(x + 1)) + (Math.Pow(Math.E, (-b * x))) * (Math.Sqrt(x + 1.5)));
                if (x < -1 &&
                    x < -1.5)
                {
                    Console.WriteLine("Одно значений не входит в ОДЗ");
                    Environment.Exit(0);
                }
                Console.WriteLine("z = " + z);
                Console.WriteLine("s = " + s);                              
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}


