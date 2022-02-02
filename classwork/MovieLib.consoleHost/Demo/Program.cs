using System;

namespace Demo
{
    class Program
    {
        static void Main ( string[] args )
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
    
