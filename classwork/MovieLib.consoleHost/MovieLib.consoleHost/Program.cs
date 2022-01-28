﻿using System;

namespace MovieLib.consoleHost
{
    class Program
    {
        //Entry point
        static void Main ( string[] args )
        {
            //Block style declaration - all variables declared at top of function
            //on demand / inline declaration - variables are declared as needed

            char input = DisplayMenu();

            //Handle input
            if (input== 'A')
                AddMovie();
        }

        private static void AddMovie () 
        {
            string tittle = ReadString("Enter a movie tittle", true);
            int duration = ReadInt32("Enter duration in minutes(>=0):", 0);
            int releaseYear = ReadInt32("Enter the release year:", 1900);
            string rating = ReadString("Enter a rating (e.g PG-13):", true);
            string genre = ReadString("Enter a genre(optional:)", false);
            bool isColor;
            string description = ReadString("Enter a description (optional):",false);
        
        }

        private static int ReadInt32 ( string message, int minimumValue )
        {
            Console.Write(message);
            string input = Console.ReadLine();
            //TODO: Validate
            int result = Int32.Parse(input);
            if (result>= minimumValue)
                return result;
            return result;
        }

        //Function naming rules
        //Functions are actions-> verbs
        //functions are always pascal cased
        //funtions should do a single, logical thing

        private static string ReadString ( string message, bool required )
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            //Todo: Validate input, if required
            return input;
        }

        static char DisplayMenu ()
        {
            Console.WriteLine("A)dd Movie");
            Console.WriteLine("V)iew Movie");
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();

            //Validate input
            if (input == "A")
                return 'A';
            else if (input == "V")
                return 'V';
            else if (input == "E")
                return 'E';
            else if (input == "D")
                return 'D';
            else if (input == "Q")
                return 'Q';
            else
            {
                Console.WriteLine("Invalid Input");
                return 'X';
            };

        
        }
        
    }
}
