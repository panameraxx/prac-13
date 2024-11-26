using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1  Найти минимальную величину из двух целых переменных a, b,
            //используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Минимальная величина = {Min(x, y)}");
            Console.ReadKey();
        }
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
    }
}
