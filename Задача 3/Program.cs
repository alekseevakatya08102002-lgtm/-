using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, a = 0, b = 0, i = 0, j = 0, n = 0;
            Console.WriteLine("Введите стороны прямоугольника А и В по порядку:");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата С:");
            C = Convert.ToInt32(Console.ReadLine());
            a = A;
            b = B;
            while (a >= C)
            {
                a = a - C;
                i++;
            }
            while (b >= C)
            {
                b = b - C;
                j++;
            }
            if (i == 0 || j == 0)
            {
                Console.WriteLine("В данном прямоугольник не поместится ни одного квадрата со стороной С");
            }
            else
            {
                while (i > 0)
                {
                    n = n + j;
                    i = i - 1;
                }
                Console.WriteLine("В прямоугольник со сторонами помещается {0} квадратов со стороной С", n);
            }
            Console.ReadLine();
        }
    }
}
