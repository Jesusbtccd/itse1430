﻿using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoPrimitives();

            //Arithmetic operators
            int x = 10, y = 20, z;
            z = x +y;
            z = x - y;
            z = x * y;
            z = x % y;

            //x++ prefix increment
            // temp = x;
            // x += 1;
            // temp;
            x = 10;
            x++;

            //++x postfix increment
            // x +=1;
            // x;
            ++x;

            //x-- prefix decrement
            // temp = x;
            // x -= 1;
            //temp
            //Primitives
            //Intergals
            sbyte sbyteValue = 10;
            short shortValue = 20;
            int intValue = 62_543;
            long longValue = 40L;

            //Floats
            float floatValue = 45.6f;
            double doubleValue = 5678.115;
            decimal payRate = 17.50M;

            bool isSuccessful = true;
            bool isFailing = false;

            char letterGrade = 'A';
            string name = "Bob";

            //Please dont do this
            int hoursWorked;
            hoursWorked = 0;

            //definitely assigned
            //hoursWorked = 10;
            intValue = hoursWorked;
       
        }
    }
}
