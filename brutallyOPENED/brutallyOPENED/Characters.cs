using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brutallyOPENED
{
    internal class Characters
    {
        //display
        //add
        //remove

        public static void Display_(int x, int y)
        {
            //print all characters with its keycode
            //wait for input
            Text.RemoveOverFlow(x, y);
            while(true)
            {
                Console.SetCursorPosition(x, y);

                Text.CenterLine(" - Characters - ");
                Text.NewLine();
                Text.Center("All characters and their key codes");

                for(int i = 0; i < Display.allChars.Length; i++)
                {
                    if(i % 5 != 0)
                    {
                        Console.Write("[ " + (int)Display.allChars[i] + " ; " + (char)Display.allChars[i] + " ]");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }

                Console.ReadKey();
                break;
            }    
        }


    }
}
