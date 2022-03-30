//Jesus Bustillos
//ITSE-1430
//03/10/2022
using System;

namespace Bustillos_Jesus.AdventureGame.ConsoleHost
{

    class Program
    {
        static string s_characterName;


        static void Main ( string[] args )
        {
            DisplayProgramInformation();
            displayStart();
            begin();
        }

        static void DisplayDivider ( int width = 80 )
        {
            Console.WriteLine("".PadLeft(width, '-'));
            Console.WriteLine("\"Press Enter to continue\"");
        }

        public static void displayStart ()
        {
            Console.WriteLine("Adventure Game");
            Console.WriteLine("Welcome to the Tarrant County Adventure Game.");
            Console.WriteLine("What would you like your character's name to be?");
            s_characterName = Console.ReadLine();
            Console.WriteLine("Great! Your character is now named " + s_characterName);
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            begin();

        }

        public static void begin ()
        {
            string choice_A;

            Console.WriteLine("Welcome to our humble Medival castle");
            Console.WriteLine("You are in the Young Misses quarters, you could stay but she would not like that.");
            Console.WriteLine("1. enter Lavatory");
            Console.WriteLine("2. to the right thru the Lavatory and enter the Young Lads quarters");
            Console.WriteLine("3. proceed left and enter the Pantry");
            Console.WriteLine("4. thru the Pantry and into the King's and Queen's quarters");
            Console.Write("Choice: ");
            choice_A = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice_A)
            {
                case "1":
                case "enter Lavatory":
                case "enter":
                {
                    Console.WriteLine("You have entered the Lavatory.");
                    Console.WriteLine("You may tend to your needs accordingly but please be courteous of the next patron.");
                    Console.WriteLine("Please wash your hands when done tending to your needs.");
                    Console.WriteLine("There is hand soap in the soap dish and towels on the rack and extra in the Lavatory cubbard if needed.");
                    Console.WriteLine("Please blow out the candles when you are done and exiting the Lavatory.");
                    Console.WriteLine("\"press Enter to continue\"");
                    Console.ReadLine();
                    begin();
                    break;
                }
                case "2":
                case "to the right thru the Lavatory and enter the Young Lads quarters":
                {
                    Console.WriteLine("You are in the Young Lads quarters.");
                    Console.WriteLine("Please feel free to look at his many shields and swords but do not disturb them.");
                    Console.WriteLine("He has many maps as well that he is collecting");
                    Console.WriteLine("\"press Enter to continue\"");
                    Console.ReadLine();
                    begin();
                    break;
                }
                case "3":
                case "proceed left and enter the Pantry":
                case "proceed":
                {
                    Console.WriteLine("You are in the Pantry.");
                    Console.WriteLine("Please feel free to serve yourself a beverage.");
                    Console.WriteLine("There is also fresh bread in the basket.");
                    Console.WriteLine("\"press Enter to continue\"");
                    Console.ReadLine();
                    second();
                    break;
                }
                case "4":
                case "thru the Pantry and into the King's and Queen's quarters":
                case "thru":
                {
                    Console.WriteLine("You have entered the King's and Queen's quarters.");
                    Console.WriteLine("The King has many crowns as they say in a figuratively manner.");
                    Console.WriteLine("Please continue your tour of the Castle."); 
                    Console.ReadLine();
                    second();
                    break;
                }
                default:
                {

                    Console.WriteLine("Command is invalid...");
                    Console.WriteLine("Press 'Enter' to restart.");
                    Console.ReadLine();
                    begin();
                    break;
                }

            }
        }

        
        public static void second()
        {
            Random rnd = new Random();
            string[] secondOptions = { "How are you enjoying the tour of the castle thus far?",
            "Did you enjoy your vist to the Young Lads quarters? He does prize in his many belongings.",
            "What would you like to see next?"}; 
            int randomNumber = rnd.Next(0, 3);
            string secText = secondOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("option 1");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("Please adjourn to the Pantry or the Family Living quarters.");
                Console.ReadLine();
                Console.Clear();
                third();

            } else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("Although he does prize in his many belongings some are not for the faint of heart.");
                Console.WriteLine("Most that visit do enjoy his worldly maps given to him by his Grandfather.");
                Console.ReadLine();
                second();

            } else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                begin();
            }

        }

        public static void third ()

        {
            int Decision;
            Console.WriteLine("Great! He will returns from his studies soon.");
            Console.WriteLine("Please have a seat and patiently wait.");
            Console.WriteLine("Will you be waiting or returning? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Decision);
            int loop = 0;
            bool wait = false;
            while (Decision != 1 && wait == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("Ok, would you like a beverage while you wait?.");
                    Console.WriteLine("You may read one of the many books in the Family Living quarters?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop++;
                } else if (loop >= 1)
                {
                    Console.WriteLine("Ok, I will tell him how much you admired his many belongings.");
                    Console.WriteLine("Will you be returning soon? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    wait = true;
                }

            }
            if (wait == true)
            {
                Console.WriteLine("Ok, I shall give him notice that you will be returning.");
                Console.WriteLine("Please be careful on your journey.");
                Console.ReadLine();
                gameOver();
            } else

            {
                Console.WriteLine("Please feel free to relax and wait in the Family Living quarters.");
                Console.ReadLine();
                youWin();
            }
        }

        public static void gameOver ()
        {
            Console.Clear();
            Console.WriteLine("Thank you for visiting the Castle.");
            Console.WriteLine("The End?");
            Console.ReadLine();
            Console.Clear();
            displayStart();
        }

        public static void youWin ()
        {
            Console.Clear();
            Console.WriteLine("Thank you for touring the Castle.");
            Console.WriteLine("Please continue to tour the Castle.");
            Console.ReadLine();
            Console.Clear();
            displayStart();
        }

        static void DisplayProgramInformation ()
        {
            Console.WriteLine("Jesus Bustillos");
            Console.WriteLine("Adventure Game");
            Console.WriteLine("ITSE 1430_Spring_2022");
            DisplayDivider();
            Console.ReadKey();

        }


    }

}


    


