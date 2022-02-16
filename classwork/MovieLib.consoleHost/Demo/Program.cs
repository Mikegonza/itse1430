using System;

namespace Demo
{
    class Program
    {
        static void Main ( string[] args )

        // strings
        {
            var payRate = 8.75;
            var payRatesString = payRate.ToString();
            payRatesString = 5.ToString();
            payRatesString = (4+5).ToString();
            // Escape sequence- character sequence that represents somenthing that is unprintable
            //\n newline
            //  \t horizontal tab
            //   \\ single slash
            //    \" double quote
            string literal = "hello World\nBob";
            string filePath = "C:\\windows\\system32";
            string filePath2 = @"C\windows\system32";  // verbatim string ignores escape sequences

            string nullString = null; // no value
            string emptyString = "";
            string emptyString2 = String.Empty;
            bool areNotEqual = nullString == emptyString;

            //nullString.ToString(); //Crash
            //nullString + emptyString; // ok

            // usefull string functions
            // determine if string is null or empty

            bool isEmpty = (emptyString == null ||emptyString == ""); // Dont do this!!
            isEmpty = String.IsNullOrEmpty(emptyString);
            isEmpty = emptyString.Length == 0;  // will crash if null 

            // case sensitive
            string lowerName = "bob", upperName = "BOB";
            bool areStringEqual = lowerName== upperName; //false
            areNotEqual = lowerName.ToUpper() == upperName.ToUpper(); //Normalize, true
            areStringEqual = String.Compare(lowerName, upperName, true)==0; // StringComparison.IgnoreCase //not
            areStringEqual= String.Equals(lowerName, upperName, StringComparison.CurrentCultureIgnoreCase);

            //usefull string functions
            bool startsWithletter = lowerName.StartsWith("B"); // EnsWith("B")
            lowerName = " Bob ";
            lowerName = lowerName.Trim(); // "Bob"  // TrimStart, TrimEnd
            // add leading spaces
            lowerName.PadLeft(20); // addRigth

            // joining strings
            String.Join(' ', "Bob", "William", "Smith");  //"Bob William Smith
            string numbers = String.Join(",", 1, 2, 3, 4);    // "1,2,3,4"

            //split string
            var tokens = "1|2|3|4".Split("|");   
            //common lenguGE RUNTIME (CLR)
            



        }
       
          {
            //DemoPrimitives();
            //Arithmetic opeerators
            int x = 10, y = 20, z;
            z= x+y;
            z= x-y;
            z= x*y;
            z= x/y;
            z= x%y;
            //x++ prefix increment
            //temp=x;
            //x+1=1;
            //temp;
            x=10;
            x++;

            //++x posfix increment
            //x+=;
            //x;
            ++x;

            //x-- prefix decrement
            //temp=x;
            //x-=1;
            //temp;
            x=10;
            x--;

            //--x posfix decrement
            //x-=1;
            //x;
            --x;


        }
        static void DemoPrimitves ()
        {
        //Primitives
        //Integrals
            sbyte sbyteValue = 10;
            short shortValue = 20;
            int intValue = 62_543;
            long longValue = 10;
            //Floats
            float floatValue = 45.6F;
            double doubleValue = 5678.115;
            decimal payRate = 17.50M;

            bool isSuccessful = true;
            bool isFalling = false;

            char letterGrade = 'A';

            string name = "Bob";

            int hoursWorked;
            hoursWorked=0;
            //Definitely assigned
            hoursWorked =10;
            intValue = hoursWorked;
        }
    }
 }
    
