using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Всем привет!" );
            Console.Write("Меня зовут Андрей! ");
            Console.Write("Я люблю Ставрополь! " );
            Console.Write("Интерисуюсь баскетболом! ");
            Console.CursorLeft = 0;
            Console.CursorTop = 2;
            Console.WriteLine("     ********     ");
            Console.CursorLeft = 0;
            Console.CursorTop = 3;
            Console.WriteLine("    **********     ");
            Console.CursorLeft = 0;
            Console.CursorTop = 4;
            Console.WriteLine("   ************    ");
            Console.CursorLeft = 0;
            Console.CursorTop = 5;
            Console.WriteLine("  ***  ***  ***   ");
            Console.CursorLeft = 0;
            Console.CursorTop = 6;
            Console.WriteLine("  **************   ");
            Console.CursorLeft = 0;
            Console.CursorTop = 7;
            Console.WriteLine("  **  *****   **  ");
            Console.CursorLeft = 0;
            Console.CursorTop = 8;
            Console.WriteLine("   *          *   ");
            Console.CursorLeft = 0;
            Console.CursorTop = 9;
            Console.WriteLine("    **********    ");
            Console.ReadKey();
            Console.CursorLeft = 5;
            Console.CursorTop = 9;
            Console.WriteLine("    *         ");
            Console.CursorLeft = 9;
            Console.CursorTop = 9;
            Console.WriteLine("        *     ");
            Console.ReadKey();
        }
    }
}
