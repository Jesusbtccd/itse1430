//Jesus Bustillos
//ITSE 1430 Spring 2022
//03/10/2022

using System;

namespace JesusBustillos.AdventureGame.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayProgramInformation();
            int player = 1;
            var done = false;

            do
            {
                char input = ActionMenu();

                switch (input)
                {
                    case 'c':   //Fallthrough allowed when case statement is empty
                    case 'C': player = UpCharacter(player); break;
                                
                    case 'v':
                    case 'V': player = LeftCharacter(player); break;

                    case 'b':
                    case 'B': player = RightCharacter(player); break;

                    //case 'd':
                    //case 'D': DeleteCharacter(); break;

                    case 'x':
                    case 'X': player = DownCharacter(player); break;

                    case 'q':
                    case 'Q':
                    {
                        if (ConfirmQuit())

                            done = true;

                        break;
                    };
                    default: Console.WriteLine("Unknown option"); break;
                };
            } while (!done);
        }
        static char ActionMenu ()
        {
            Console.WriteLine("C)Forward Character");
            Console.WriteLine("V)Left Character");
            Console.WriteLine("B)Right Character");
            Console.WriteLine("X)Reverse Character");
            Console.WriteLine("Q)uit");

            do
            {
                string input = Console.ReadLine();

                //Validate input, case insensitive
                if (String.Compare(input, "C", true) == 0)
                    return 'C';
                else if (String.Compare(input, "V", true) == 0)
                    return 'V';
                else if (String.Equals(input, "B", StringComparison.CurrentCultureIgnoreCase))
                    return 'B';
                else if (String.Compare(input, "X", true) == 0)
                    return 'X';
                else if (String.Compare(input, "Q", true) == 0)
                    return 'Q';
                else
                    Console.WriteLine("Invalid input");
            } while (true);
        }

        private static void UpCharacter (int p)
        {
            if (p == 1)
            {
                if (p == 1)
                Console.WriteLine("You are in the King and Queen's quarters.");
                return;
            }
            else if (p == 2)
                Console.WriteLine("Invalid movment.");
            else if (p == 3)
                Console.WriteLine("Invalid movement.");
            else if (p == 4)
                Console.WriteLine("invalid movement.");
            else if (p == 5)
                Console.WriteLine("Invalid movement");
            else if (p == 6)
                Console.WriteLine("Invalid movement");
            else if (p == 7)
                Console.WriteLine("Invalid movement");
            else if (p == 8)
                Console.WriteLine("Invalid movement");
            else if (p == 9)
                Console.WriteLine("Invalid movement");

        }

        private static void LeftCharacter (int p)
        {
            if (p == 1)
            {
                if (p == 1)
                    Console.WriteLine("You are in the King and Queen's quarters.");
                return;
            }
            else if (p == 2)
                Console.WriteLine("Invalid movement.");
            else if (p == 3)
                Console.WriteLine("Invalid movement.");
            else if (p == 4)
                Console.WriteLine("Invalid movement.");
            else if (p == 5)
                Console.WriteLine("Invalid movement.");
            else if (p == 6)
                Console.WriteLine("Invalid movement.");
            else if (p == 7)
                Console.WriteLine("Invalid movement.");
            else if (p == 8)
                Console.WriteLine("Invalid movement.");
            else if (p == 9)
                Console.WriteLine("Invalid movement.");
        }

        private static void RightCharacter ( int p )
        {
            if (p == 1)
            {
                if (p == 1)
                    Console.WriteLine("You are in the King and Queen's quarters.");
                return;
            } 
            else if (p == 2)
                Console.WriteLine("You are in the Private Common quarters.");
            {
                if (p == 2)
                    Console.WriteLine("You are in the King and Queen's quarters.");
                return;
            }
            else if (p == 3)
                Console.WriteLine("Invalid movement.");
            else if (p == 4)
                Console.WriteLine("Invalid movement.");
            else if (p == 5)
                Console.WriteLine("Invalid movement.");
            else if (p == 6)
                Console.WriteLine("Invalid movement.");
            else if (p == 7)
                Console.WriteLine("Invalid movement.");
            else if (p == 8)
                Console.WriteLine("Invalid movement.");
            else if (p == 9)
                Console.WriteLine("Invalid movement.");
        }



        private static void MovingCharacter ()
        {
            //movement = new Character();


            //movement.Name = ReadString("Enter a character direction: ", true);
           //while (!(movement._direction == "Forward" || movement._direction == "Left" || movement._direction == "Right" || movement._direction == "Reverse" ))
              // movement._direction = ReadString("Choose a character direction:\n Forward\n Left\n Right\n Reverse\n, true);
            //while (!(character._race == "Dwarf" || character._race == "Elf" || character._race == "Gnome" || character._race == "Half Elf" || character._race == "Human"))
            //    character._race = ReadString("Choose a character race:\n Dwarf\n Elf\n Gnome\n Half Elf\n Human", true);
            //while (character._strength <= 0 || character._strength >= 101)
            //    character._strength = ReadInt32("Enter Strength: ", 1);
            //while (character._intelligence <= 0 || character._intelligence >= 101)
            //    character._intelligence = ReadInt32("Enter Intelligence: ", 1);
            //while (character._agility <= 0 || character._agility >= 101)
            //    character._agility = ReadInt32("Enter Agility: ", 1);
            //while (character._constitution <= 0 || character._constitution >= 101)
            //    character._constitution = ReadInt32("Enter Constitution: ", 1);
            //while (character._charisma <= 0 || character._charisma >= 101)
            //    character._charisma = ReadInt32("Enter Charisma: ", 1);
            //character._description = ReadString("Enter a description (optional): ", false);


        }

        //private static void ViewCharacter ()
        //{

        //    if (movement == null)
        //    {
        //        Console.WriteLine("No character to view");
        //        return;
        //    };

        //    Console.WriteLine(character.Name);
        //    Console.WriteLine($"{character._race}");
        //    Console.WriteLine($"{character._profession}");
        //    Console.WriteLine(character._description);
        //}

        static bool ConfirmQuit ()
        {
            return ReadBoolean("Are you sure you want to quit (y/n)? ");
        }

        static bool ReadBoolean ( string message )
        {
            Console.Write(message);

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Y)
                {
                    Console.WriteLine('Y');
                    return true;
                } else if (key.Key == ConsoleKey.N)
                {
                    Console.WriteLine('N');
                    return false;
                };
            } while (true);
        }


        //static int ReadInt32 ( string message, int minimumValue )
        //{
        //    Console.Write(message);

        //    while (true)
        //    {

        //        var input = Console.ReadLine();


        //        if (Int32.TryParse(input, out var result) && result >= minimumValue)
        //            return result;

        //        Console.WriteLine("Value must be between 1-100");
        //    };
        //}

        private static string ReadString ( string message, bool required )
        {
            Console.WriteLine(message);

            do
            {
                string input = Console.ReadLine();

                //Validate if required
                if (!required || !String.IsNullOrEmpty(input))
                    return input;

                Console.WriteLine("Direction is required");
            } while (true);
        }

        static void DisplayProgramInformation ()
        {
            Console.WriteLine("Jesus Bustillos");
            Console.WriteLine("Adventure Game");
            Console.WriteLine("ITSE 1430_Spring_2022");
            //DisplayDivider();
            Console.WriteLine("Welcome to Tarrant Conunty Medieval Game. You will be exploring the adjecent rooms within a Medieval Castle.");
            Console.ReadKey();
            
        }
    }
}
