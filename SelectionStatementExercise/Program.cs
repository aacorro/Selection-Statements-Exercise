using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("What is the upper limit of the range of the number?");
            var userRange = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Great! Let's begin! Try to guess my favorite number");
            var userGuess = int.Parse(Console.ReadLine()!);


            var num = new Random();
            var luckyNumber = num.Next(0, userRange);
            
            
            

            if (userGuess < luckyNumber)
            {
                Console.WriteLine($"{userGuess} is Too low. The number I had in mind was {luckyNumber}.");
                Console.WriteLine($"Let's try again but now I might have a different favorite number...");
            }

            else if (userGuess > luckyNumber)
            {
                Console.WriteLine($"{userGuess} is Too high. The number was {luckyNumber}.");
                Console.WriteLine($"Let's try again but now I might have a different favorite number...");
            }
            else
            {
                Console.WriteLine($"Correct! My favorite number is {userGuess}");
            }


            // Exercise 22

            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();


            switch (subject.ToLower())
            {
                case "biology":
                    Console.WriteLine("Cells, mitosis, and all that!");
                    break;
                case "chemistry":
                    Console.WriteLine("Acids, superacids, ultrasuperacis...Wow!");
                    break;
                case "geology":
                    Console.WriteLine("MINERALS!!");
                    break;
                case "physics":
                    Console.WriteLine("Newton and Einstein's laws! Fantastic!");
                    break;
                case "astronomy":
                    Console.WriteLine("Planets, asteroids, metors! Fun stuff!");
                    break;
                default:
                    Console.WriteLine($"So you are a {subject +"able"} type of person! Nice class!");
                    break;

            }

        } 
        
    }
}