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
            do
            { 
            char input = DisplayMenu();
            
            
                //Handle input
               // if (input== 'A')
               //     AddMovie();
               // else if (input =='V')
                //    ViewMovie();
               // else if (input =='Q')
               //     if (confirmQuit())
               //         break; //exits the loop
               switch (input)
                {
                    case 'a':
                    case 'A': AddMovie();break;
                    case 'v':
                    case 'V': ViewMovie();break;
                    case 'q':
                    case 'Q':
                    {
                        if (confirmQuit())
                            break;
                        break;
                    };
                    default: Console.WriteLine("Unknown option"); break;
                };
               } while (true);
        }
        private static void ViewMovie()
        {
            //ToDo movie exist
            Console.WriteLine(title);
            // releaseYear (run length: duration minutes) rating
            //formatin 1 string concatenation
            //Console.WriteLine (releaseYear + " (" + duration + " mins) " + rating);
            
            // formating 2 string contatenatinon
            //Console.WriteLine("{0} ({1}mins) {2}", releaseYear, duration, rating);
            //string temp = String.Format("{0} ({1}mins) {2}", releaseYear, duration, rating);
            //Console.WriteLine(temp);

            //formating 3 string interpolation
            Console.WriteLine($"{releaseYear } ({duration} mins) {rating}");

            //genre (color black white)
            //Console.WriteLine(genre + " (  + isColor" + ")");
            // Console.WriteLine($"{genre} ({isColor})");
            //if (isColor)
            //  Console.WriteLine($"{genre} (color)");
            //else
            //Console.WriteLine($"{ genre} (Black and white)");
            // conditional operator
            Console.WriteLine($"{genre} ({(isColor ? "Color" : "Black and White")})");

            Console.WriteLine(releaseYear);
            Console.WriteLine(duration);
            Console.WriteLine(isColor);
            Console.WriteLine(description);
            Console.WriteLine(genre);

        }
        static bool confirmQuit()
        {
            return ReadBoolean("Are you sure you wnat to quit (Y/N)? ");

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
        //unit 1 only
        static string title;
        static int duration;
        static int releaseYear;
        static string rating;
        static string genre;
        static bool isColor;
        static string description;
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
                //type inferencing - compiler infers actual type based upon usage
                //has 0 impact on runtime behavior
                //string input = Console.ReadLine();
                var input = Console.ReadLine();

                //TODO: Validate
                //int result = Int32.Parse(input);
                //int result;
                //if (Int32.TryParse(input, out result))

                //if (Int32.TryParse(input, out int result))
                //   if (result >= minimumValue)
                //    return result;

                //  Console.WriteLine("Value must be >= " + minimumValue);
                if (Int32.TryParse(input, out var result) && result >= minimumValue)
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
