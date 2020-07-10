using System;

//1:Write a c# program that takes user input and creates an adlib story.
//Ask the user for things like a name, color, an animal, etc.Make up a story and be creative.
//Hint:
//Use Console.ReadLine() to take user input and store the input into a variable.
//For example:  
//Ask the user “What is your name?”
//Store the input

//EXAMPLE:
//	var name = Console.ReadLine();

//Record user input, for each of these.Combine all answers for a fun, short story.
//Hint:
//FW
//Name: Michael
//Favorite Color: Blue
//Favorite Animal: Walrus
//Favorite Band: The Beatles
//Extra points - turn the answers into a fun short story!


namespace AdLibStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friend!");

            Console.WriteLine("Hi there! What's your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hi {userName} What's your Zodiac Sign?");
            var zodiacSign = Console.ReadLine();
            Console.WriteLine($"What do you like to do for fun, {userName}?");
            var forFun = Console.ReadLine();
            Console.WriteLine($"OK {userName}, tell me, where do you see yourself in 3 years?");
            var seeThree = Console.ReadLine();
        }
    }
}
