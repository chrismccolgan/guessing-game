﻿using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Guess the secret number: ");
                string answer = Console.ReadLine();
                int num = int.Parse(answer);

                if (num == secretNumber)
                {
                    Console.WriteLine("Congratulations!");
                    break;
                }
                else
                {
                    if (num > secretNumber)
                    {
                        Console.WriteLine($"Too high! Chances remaining: {3-i}");
                    }
                    else
                    {
                        Console.WriteLine($"Too low! Chances remaining: {3-i}");
                    }
                }
            }
        }
    }
}