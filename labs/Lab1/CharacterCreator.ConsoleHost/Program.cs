using System;
/*
 * Miguel Angel Gonzalez Mauricio
 * ITS 1430
 * Lab 1
 */

namespace CharacterCreator.ConsoleHost
{ internal class Program        
    {
        private static string nameCharacter;
        private static string profession;
        private static string race;
        private static string attribute;

        static void Main ( string[] args )
       
        
        {
            var done = false;
            do
            {
                char input = DisplayMenu();

                switch (input)
                {
                    case 'c':
                    case 'C': CreateCharacter(); break;
                    case 'v':
                    case 'V': ViewCharacter(); break;
                    case 'e':
                    case 'E': EditCharacter(); break;
                    case 'd':
                    case 'D': DeleteCharacter(); break;
                    case 'q':
                    case 'Q':
                    {
                        if (confirmQuit())
                            done = true;
                        break;
                    };
                    default: Console.WriteLine("Unknown option"); break;
                };
            } while (!done);

 }
        
        static char DisplayMenu ()
            {
                Console.WriteLine("Game Menu");
                Console.WriteLine("".PadLeft(20, '-'));
                Console.WriteLine("C)reate Character");
                Console.WriteLine("V)iew Character");
                Console.WriteLine("E)dit Character");
                Console.WriteLine("D)elete Character");
                Console.WriteLine("Q)uit");

                do
                {
                    string input = Console.ReadLine();
                    
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
            private static void CreateCharacter ()
            
            {           
            nameCharacter=ReadString("Enter the Name of the character ", true);
            profession=ReadString("Enter the Profesion of the Character", true);
            race=ReadString ("Enter the race of the character", true);
            attribute=ReadString ("Enter the Attributes for the Character", true);

            }                        
            private static void DeleteCharacter ()
            {
                if (String.IsNullOrEmpty(nameCharacter))
                {
                    Console.WriteLine("No Character to delete");
                    return;
                };
               
                if (ReadBoolean($"Are you sure you want to delete '{nameCharacter}' (Y/N)"))
                    nameCharacter = "";
            }           
            private static void ViewCharacter ()
            {
                if (String.IsNullOrEmpty(ViewCharacter ))
                {
                    Console.WriteLine("No Character to show");
                    return;
                };
                Console.WriteLine( ViewCharacter );               
                Console.WriteLine($"{nameCharacter} {profession}  {race} {attribute}");
            }      
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












