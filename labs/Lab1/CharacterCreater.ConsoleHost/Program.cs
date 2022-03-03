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
            Console.WriteLine("D)elete Charater");
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

        // Add a Character
        private static void CreatingCharacter ()
        {
            character = new Character();

            do
            {
                character.Name = ReadString("Enter a character name: ", true);
                character._profession = ReadString("Enter profession: ", true);
                character._race = ReadString("Enter race: ", true);
                character._attributes = ReadString("Enter a Attribute: ", true);
                character._strength = ReadInt32("Enter Strength: ", 1);
                character._intelligence = ReadInt32("Enter Intelligence: ", 1);
                character._agility = ReadInt32("Enter Agility: ", 1);
                character._constitution = ReadInt32("Enter Constitution: ", 1);
                character._charisma = ReadInt32("Enter Charisma: ", 1);
                character._description = ReadString("Enter a description (optional): ", false);

                
                //var error = character.Validate();
                //if (String.IsNullOrEmpty(error))
                    return;

                //Console.WriteLine(error);
            } while (true);
        }

        // Deletes a Character
        private static void DeleteCharacter ()
        {
            
            if (character == null)
            {
                Console.WriteLine("No charcter to delete");
                return;
            };

            //Confirm and delete the movie
            if (ReadBoolean($"Are you sure you want to delete '{character.Name}' (Y/N)"))
                character = null;
        }

        //View a Character
        private static void ViewCharacter ()
        {
            //Does movie exist
            //if (String.IsNullOrEmpty(movie.title))
            if (character == null)
            {
                Console.WriteLine("No character to view");
                return;
            };

            Console.WriteLine(character.Name);

            //Desired format: releaseYear (duration mins) rating

            //Formatting 1 - string concatenation
            //  Console.WriteLine(releaseYear + " (" + duration + " mins) " + rating);
            //Formatting 2 - string formatting
            //  Console.WriteLine("{0} ({1} mins) {2}", releaseYear, duration, rating);
            //  string temp = String.Format("{0} ({1} mins) {2}", releaseYear, duration, rating);
            //  Console.WriteLine(temp);
            //Formatting 3 - string interpolation
            Console.WriteLine($"{character._race}{character._profession}{character._attributes}");

            //Conditional operator
            //Console.WriteLine($"{movie._genre} ({(movie._isClassic ? "Classic" : "")})");
            Console.WriteLine(character._description);
        }

        //TODO: Fix these variables to remove warnings
        static Character character;

        // Get confirmation from user to quit
        static bool ConfirmQuit ()
        {
            return ReadBoolean("Are you sure you want to quit (y/n)? ");
        }

        //Reads a boolean input from user
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

        // Reads an integral value from user
        static int ReadInt32 ( string message, int minimumValue )
        {
            Console.Write(message);

            while (true)
            {

                var input = Console.ReadLine();


                if (Int32.TryParse(input, out var result) && result >= minimumValue)
                    return result;

                Console.WriteLine("Value must be between 1-100" + minimumValue);
            };
        }

        //// Reads a(n), optionally required, string from the user
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
