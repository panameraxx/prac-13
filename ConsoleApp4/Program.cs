using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3 Найти s = min(a, b) + min(c, d), 
            //используя вспомогательные функции(ввода аргументов, нахождения минимальной величины, вывода результата).
            int a = Input("a = ");
            int b = Input("b = ");
            int c = Input("c = ");
            int d = Input("d = ");
            int s = Min(a, b) + Min(c, d);
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int x, int y)
        {
            return x< y ? x : y;
        }
    }
}
