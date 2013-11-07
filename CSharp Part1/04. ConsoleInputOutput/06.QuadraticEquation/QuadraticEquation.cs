﻿/*
 * Write a program that reads the coefficients a, b and c
 * of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
 */

using System;

namespace ConsoleInputOutput
{
    class QuadraticEquation
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Welcome to the quadratic equation solver!");
            Console.WriteLine("Please enter the coefficients of ax^2 + bx + c:");
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("c = ");
            int.TryParse(Console.ReadLine(), out c);

            int discriminant = b * b - (4 * a * c);

            if (discriminant < 0)
            {
                Console.WriteLine("This equation has no real roots.");
            }
            else
            {
                int root1, root2;
                root1 = (-b + discriminant) / (2 * a);
                root2 = (-b - discriminant) / (2 * a);

                if (root1 == root2)
                {
                    Console.WriteLine("The root is: {0}", root1);
                }
                else
                {
                    Console.WriteLine("The roots are: {0}, {1}", root1, root2);
                }
            }
        }
    }
}