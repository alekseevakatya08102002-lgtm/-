using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, n_1 = 0, n1 = 0;
            Console.WriteLine("Вводите числа, для завершения последовательности введите 0");
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N < 0)
                {
                    n_1++;
                }
                else if (N > 0)
                {
                    n1++;
                }
                else if (N == 0)
                {
                    Console.WriteLine("Ввод чисел прерван");
                    Console.WriteLine();
                }
            } while (N > 0 || N < 0);
            Console.WriteLine("Количество введенных положительных чисел: {0}", n1);
            Console.WriteLine("Количество введенных отрицательных чисел: {0}", n_1);
            Console.ReadKey();
        }
    }
}
