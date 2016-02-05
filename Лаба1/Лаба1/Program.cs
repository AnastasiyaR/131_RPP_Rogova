using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int t;
            x = 5;
            y = 2;
            z = x * y;
            Console.WriteLine("Заданы исходные значения х=5, у=2. При умножении получим переменную z.");
            Console.WriteLine("z={0}", z); 
            if (z > 0)
            {
                Console.WriteLine("Число z положительное");
            }
            else
            {
                Console.WriteLine("Число z отрицательное");
            }
            if (z%2==0)
            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("нечетное");
            }
            if (z % 5== 0)
            {
                Console.WriteLine("делится без остатка на 5");
            }
            else
            {
                Console.WriteLine("не делится без остатка на 5");
            }
            Console.WriteLine("Следующее действие. Отнимем от z единицу.");
            t = z - 1;
                Console.WriteLine("z={0}", t);
            Start:
                t--;
            if (t > 0)
            {
                Console.WriteLine("z={0}", t);
                goto Start;
            }
            else
            {
                Console.WriteLine("z={0}", t);
            }
            Console.ReadKey();
        }
    }
}