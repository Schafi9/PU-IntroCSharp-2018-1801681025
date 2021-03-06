﻿using System;

namespace A.CircleArea
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            const double pi = Math.PI;                // Since it won't change, this variable can be a constant.
            double circleRadius = rand.Next(33, 188); // Don't forget that the first number of Next() is included and the second is not! That's why it's 188 and not 187.

            // Calculate the area of the circle using simple Math.
            double circleArea = pi * circleRadius * circleRadius;
            Console.WriteLine("The circle's random height is: " + circleRadius);
            // Rather than using concatenation as in the output above, we use this technique
            // because we need to edit the output.
            Console.WriteLine("The circle's area is: {0:F2}", circleArea);
        }
    }
}
