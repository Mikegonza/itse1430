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
            // Escape sequence- character sequence that represents somenthing that is unprintable
            //\n newline
            //  \t horizontal tab
            //   \\ single slash
            //    \" double quote
            string literal = "hello World\nBob";
            string filePath = "C:\\windows\\system32";
            string filePath2 = @"C\windows\system32";  // verbatim string ignores escape sequences



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
    
