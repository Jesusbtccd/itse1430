﻿//Jesus Bustillos
//ITSE 1430
//02/17/2022


using System;

namespace CharacterCreater.ConsoleHost
{
    internal class CharacterMain
    {
        //private static object character;

        static void Main ( string[] args)
        {

            var done = false;

            do
            {
                char input = DisplayMenu();

                switch (input)
                {
                    case 'c':   //Fallthrough allowed when case statement is empty
                    case 'C': CreatingCharacter(); break;

                    case 'v':
                    case 'V': ViewCharacter(); break;

                    case 'e':
                    case 'E': EditCharacter(); break;

                    case 'd':
                    case 'D': DeleteCharacter(); break;

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
        static char DisplayMenu ()
        {
            Console.WriteLine("C)reate Character");
            Console.WriteLine("V)iew Character");
            Console.WriteLine("E)dit Character");
            Console.WriteLine("D)elete Character");
            Console.WriteLine("Q)uit");

            do
            {
                string input = Console.ReadLine();

                //Validate input, case insensitive
                if (String.Compare(input, "C", true) == 0)
                    return 'C';
                else if (String.Compare(input, "V", true) == 0)
                    return 'V';
                else if (String.Equals(input, "E", StringComparison.CurrentCultureIgnoreCase))
                    return 'E';
                else if (String.Compare(input, "D", true) == 0)
                    return 'D';
                else if (String.Compare(input, "Q", true) == 0)
                    return 'Q';
                else
                    Console.WriteLine("Invalid input");
            } while (true);
        }

        private static void EditCharacter ()
        {
            var done = false;
            do
            {
                char input = DisplayEditMenu();

                switch (input)
                {
                    case 'n':   //Fallthrough allowed when case statement is empty
                    case 'N': character.Name = ReadString("Change character name: ", true); break;

  
                    case 'p':
                    case 'P':
                    do
                    {
                        character._profession = ReadString("Change character profession:\n Fighter\n Hunter\n Priest\n Rogue\n Wizard", true);
                    } while (!(character._profession == "Fighter" || character._profession == "Hunter" || character._profession == "Priest" || character._profession == "Rogue" || character._profession == "Wizard")); break;
                    
                    case 'r':
                    case 'R':
                    do
                    {
                        character._race = ReadString("Choose a character race:\n Dwarf\n Elf\n Gnome\n Half Elf\n Human", true);
                    } while (!(character._race == "Dwarf" || character._race == "Elf" || character._race == "Gnome" || character._race == "Half Elf" || character._race == "Human")); break;

                    case 'a':
                    case 'A':
                    {
                        do
                        {
                            character._strength = ReadInt32("Enter Strength: ", 1);
                        }
                        while (character._strength <= 0 || character._strength >= 101);
                        do
                        {
                            character._intelligence = ReadInt32("Enter Intelligence: ", 1);
                        }
                        while (character._intelligence <= 0 || character._intelligence >= 101);
                        do
                        {
                            character._agility = ReadInt32("Enter Agility: ", 1);
                        }
                        while (character._agility <= 0 || character._agility >= 101);
                        do
                        {
                            character._constitution = ReadInt32("Enter Constitution: ", 1);
                        }
                        while (character._constitution <= 0 || character._constitution >= 101);
                        do
                        {
                            character._charisma = ReadInt32("Enter Charisma: ", 1);
                        }
                        while (character._charisma <= 0 || character._charisma >= 101);
                           
                        break;
                    }


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

        static char DisplayEditMenu ()
        {       //change character name,profession,race
            Console.WriteLine("N)Character Name");
            Console.WriteLine("P)Character Profession");
            Console.WriteLine("R)Character Race");
            Console.WriteLine("A)ttributes");
            Console.WriteLine("Q)uit");

            do
            {
                string input = Console.ReadLine();

                //Validate input, case insensitive
                if (String.Compare(input, "N", true) == 0)
                    return 'N';
                else if (String.Compare(input, "P", true) == 0)
                    return 'P';
                else if (String.Equals(input, "R", StringComparison.CurrentCultureIgnoreCase))
                    return 'R';
                else if (String.Compare(input, "A", true) == 0)
                    return 'A';
                else if (String.Compare(input, "Q", true) == 0)
                    return 'Q';
                else
                    Console.WriteLine("Invalid input");
            } while (true);
        }
        
        private static void CreatingCharacter ()
        {
            character = new Character();

           
                character.Name = ReadString("Enter a character name: ", true);
                while (!(character._profession == "Fighter" || character._profession == "Hunter" || character._profession == "Priest" || character._profession == "Rogue" || character._profession == "Wizard"))
                    character._profession = ReadString("Choose a character profession:\n Fighter\n Hunter\n Priest\n Rogue\n Wizard", true);
                while (!(character._race == "Dwarf" || character._race == "Elf" || character._race == "Gnome" || character._race == "Half Elf" || character._race == "Human"))
                    character._race = ReadString("Choose a character race:\n Dwarf\n Elf\n Gnome\n Half Elf\n Human", true);
                while (character._strength <= 0 || character._strength >= 101)
                    character._strength = ReadInt32("Enter Strength: ", 1);
                while (character._intelligence <= 0 || character._intelligence >= 101)
                    character._intelligence = ReadInt32("Enter Intelligence: ", 1);
                while (character._agility <= 0 || character._agility >= 101)
                    character._agility = ReadInt32("Enter Agility: ", 1);
                while (character._constitution <= 0 || character._constitution >= 101)
                    character._constitution = ReadInt32("Enter Constitution: ", 1);
                while (character._charisma <= 0 || character._charisma >= 101)
                    character._charisma = ReadInt32("Enter Charisma: ", 1);
            character._description = ReadString("Enter a description (optional): ", false);
            

        }    

        
        private static void DeleteCharacter ()
        {
            
            if (character == null)
            {
                Console.WriteLine("No character to delete");
                return;
            };

            //Confirm and delete the character
            if (ReadBoolean($"Are you sure you want to delete '{character.Name}' (Y/N)"))
                character = null;
        }

        
        private static void ViewCharacter ()
        {
            
            if (character == null)
            {
                Console.WriteLine("No character to view");
                return;
            };

            Console.WriteLine(character.Name);
            Console.WriteLine($"{character._race}");
            Console.WriteLine($"{character._profession}");
            Console.WriteLine(character._description);
        }

        
        static Character character;

      
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

       
        static int ReadInt32 ( string message, int minimumValue )
        {
            Console.Write(message);

            while (true)
            {

                var input = Console.ReadLine();


                if (Int32.TryParse(input, out var result) && result >= minimumValue)
                    return result;

                Console.WriteLine("Value must be between 1-100" );
            };
        }

        
        private static string ReadString ( string message, bool required )
        {
            Console.WriteLine(message);

            do
            {
                string input = Console.ReadLine();

                //Validate if required
                if (!required || !String.IsNullOrEmpty(input))
                    return input;

                Console.WriteLine("Value is required");
            } while (true);
        }

    }
}
