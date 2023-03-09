using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            {

                Console.WriteLine($"Try to guess my favorite number!!");
                var userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine($"You've gone too far!");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine($"Not high enough!");
                }
                else
                {
                    Console.WriteLine($"KA CHING!!");
                }

            }
        }
    }
}
