using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brutallyOPENED
{
    internal class Text
    {
        public static void NewLine()
        {
            Console.WriteLine("");
        }
        public static void WithTime(string s)
        {
            Console.WriteLine("     " + "[" + DateTime.Now.ToString("h:mm:ss") + "] " + s);
        }
        public static void BlankEnd(string s)
        {
            Console.WriteLine(s + new String(' ', Console.WindowWidth - s.Length));
        }
        public static void BlankStart(string s)
        {
            Console.WriteLine(new String(' ', 5) + s);
        }
        public static void BlankStartEnd(string s)
        {
            Console.WriteLine(new String(' ', 5) + s + new String(' ', Console.WindowWidth - s.Length - 5));
        }
        public static void Center(string s)
        {
            int number2;
            int number = Console.WindowWidth - s.Length;
            number = number / 2;
            number2 = number;

            if (number + number2 != s.Length)
            {
                number2++;
            }

            Console.WriteLine(new String(' ', number) + s + new String(' ', number2));
        }
        public static void CenterLine(string s)
        {
            int number2;
            int number = Console.WindowWidth - s.Length;
            number = number / 2;
            number2 = number;

            number -= 5;
            number2 -= 5;

            if (number + number2 != s.Length)
            {
                number2++;
            }

            Console.WriteLine(" =>  " + new String('+', number) + s + new String('+', number) + "  <= ");
        }
        public static void RemoveOverFlow(int x, int y)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;

            Console.Write(new String(' ', 9999));

            Console.CursorLeft = 0;
            Console.CursorTop = 0;
        }
    }
}
