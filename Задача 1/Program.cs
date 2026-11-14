using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, Sum, i, n;
            Console.Write("Введите целое число больше нуля: ");
            N = Convert.ToInt32(Console.ReadLine());
            Sum = 0;
            for (i = 1; i <= N; i++)
            {
                n = 2 * i - 1;
                Sum = Sum + n;
                Console.WriteLine("Квадрат числа {0}: {1}", i, Sum);
            }
            Console.ReadKey();
        }
    }
}
