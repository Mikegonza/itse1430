using System;

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
            bool isColor = ReadBoolean("In color? (Y/N)");
            string description = ReadString("Enter a description (optional):",false);
        
        }
        static bool ReadBoolean (string message)

        {
            Console.Write(message);
            do
            {
                ConsoleKeyInfo Key = Console.ReadKey();

                //Validate
                if (Key.Key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    return true;
                } else if (Key.Key == ConsoleKey.N)
                {
                    Console.WriteLine('N');
                    return false;
                };
            } while (true);
        }

        private static int ReadInt32 ( string message, int minimumValue )
        {
            Console.Write(message);
            while (true)
            { 

            string input = Console.ReadLine();

            //TODO: Validate
            //int result = Int32.Parse(input);
            //int result;
            //if (Int32.TryParse(input, out result))

            if (Int32.TryParse(input, out int result))
                if (result >= minimumValue)
                    return result;

                Console.WriteLine("Value must be >= " + minimumValue);



            };
            
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
