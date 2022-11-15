using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brutallyOPENED
{
    public class Display
    {
        static int maxLenght = 8;
        static int minLenght = 0;
        public static char[] allChars = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'c', 'i', 'j', 'k'};

        static string[] options = { "Settings", "Start", "End"};
        static string[] settingsOptions = { "Maximum Lenght : " + maxLenght,
                                  "Minimum Lenght : " + minLenght,
                                  "Change Characters",
                                  "Back..."};

        public static void Menu()
        {
            Console.Clear();
            Text.NewLine();
            Text.Center("[ BrutelyOPENED - negativexp] ");
            Text.CenterLine(" - READ - ");
            Text.NewLine();
            Text.Center("I'm simply not responsible for anything :)");
            Text.Center("Use at your own risk, thanks");
            Text.Center("You move by using arrows and enter to change");
            Options();
        }

        private static void Options()
        {
            int position = 0;
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            while (true)
            {
                Text.CenterLine(" - Menu - ");
                Text.NewLine();

                for(int i = 0; i < options.Length; i++)
                {
                    if(position == i)
                    {
                        Text.BlankStartEnd("[x] " + options[i]);
                    }
                    else
                    {
                        Text.BlankStartEnd("[ ] " + options[i]);
                    }
                }

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                //check for movement
                if (keyPressed.Key == ConsoleKey.UpArrow && position != 0)
                {
                    position--;
                }
                if (keyPressed.Key == ConsoleKey.DownArrow && position != options.Length - 1)
                {
                    position++;
                }

                //check what options is selected
                if(keyPressed.Key == ConsoleKey.Enter)
                {
                    //Settings
                    if(position == 0)
                    {
                        Settings(x, y);
                        Text.RemoveOverFlow(x, y);
                    }
                    //Start
                    if(position == 1)
                    {
                        Text.BlankStartEnd("start...");
                    }
                    //End
                    if(position == 2)
                    {
                        Text.BlankStartEnd("Closing program...");
                        Environment.Exit(0);
                    }
                }
                Console.SetCursorPosition(x, y);
            }
        }

        private static void Settings(int x, int y)
        {
            int postion = 0;

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Text.CenterLine(" - Settings - ");
                Text.NewLine();

                //check and change postion
                for(int i = 0; i < settingsOptions.Length; i++)
                {
                    if(postion == i)
                    {
                        Text.BlankStartEnd("[x] " + settingsOptions[i]);
                    }
                    else
                    {
                        Text.BlankStartEnd("[ ] " + settingsOptions[i]);
                    }
                }

                int yEnd = Console.CursorTop;

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                //check for movement
                if(keyPressed.Key == ConsoleKey.UpArrow && postion != 0)
                {
                    postion--;
                }
                if (keyPressed.Key == ConsoleKey.DownArrow && postion != settingsOptions.Length-1)
                {
                    postion++;
                }

                //check for selected setting
                if(keyPressed.Key == ConsoleKey.Enter)
                {
                    //max lenght
                    if(postion == 0)
                    {
                        Console.CursorLeft = 26;
                        Console.CursorTop = y + settingsOptions.Length-2;
                        string input = Console.ReadLine();
                        maxLenght = int.Parse(input);


                        if(input != "")
                        {
                            try
                            {
                                maxLenght = int.Parse(input);
                                settingsOptions[0] = "Maximum Lenght : " + maxLenght;
                            }
                            catch (Exception)
                            {
                                Console.CursorTop = yEnd;
                                Text.Center("PLEASE ENTER ONLY WHOLE NUMBERS!");
                                Text.Center("press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                    }
                    //min lenght
                    if(postion == 1)
                    {
                        Console.CursorLeft = 26;
                        Console.CursorTop = y + settingsOptions.Length-1;
                        string input = Console.ReadLine();

                        if (input != "")
                        {
                            try
                            {
                                minLenght = int.Parse(input);
                                settingsOptions[1] = "Minimum Lenght : " + minLenght;
                            }
                            catch (Exception)
                            {
                                Console.CursorTop = yEnd;
                                Text.Center("PLEASE ENTER ONLY WHOLE NUMBERS!");
                                Text.Center("press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                    }
                    //characters
                    if(postion == 2)
                    {
                        Characters.Display_(x, y);
                        Text.RemoveOverFlow(x, y);
                    }
                    //back
                    if(postion == 3)
                    {
                        break;
                    }
                }
            }
        }

        private static void ResetColors()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ChangeCharacters(int x, int y)
        {

        }
    }
}
