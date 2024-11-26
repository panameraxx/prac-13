using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2 Найти минимальную величину их трех целых переменных a, b,
            //с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
            int x = Input("x= ");
            int y = Input("y= ");
            int z = Input("z= ");
            int min = Min(Min(x, y), z);
            Console.WriteLine($"Минимальное значение = {min}");
            Console.ReadKey();
        }
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
    }
}
