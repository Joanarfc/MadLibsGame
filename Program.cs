using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a Mad Lib Sentence program. It consists on building a sentence with words inputted by the user
            Author: Joana Carvalho
            */

            // Let the user know that the program is starting:
            Console.WriteLine("The MAD LIDS program will start now...");

            // Give the Mad Lib a title:
            string title = "Mad Libs Sentence";
            Console.WriteLine(title);

            // Define user input and variables:
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter an adjective:");
            string firstAdjective = Console.ReadLine();
            Console.WriteLine("Enter a second adjective:");
            string secondAdjective = Console.ReadLine();
            Console.WriteLine("Enter a third adjective:");
            string thirdAdjective = Console.ReadLine();
            Console.WriteLine("Enter a verb:");
            string verbName = Console.ReadLine();
            Console.WriteLine("Enter a first noun:");
            string firstNoun = Console.ReadLine();
            Console.WriteLine("Enter a second noun:");
            string secondNoun = Console.ReadLine();
            Console.WriteLine("Enter an animal:");
            string animalName = Console.ReadLine();
            Console.WriteLine("Enter a food:");
            string foodName = Console.ReadLine();
            Console.WriteLine("Enter a fruit:");
            string fruitName = Console.ReadLine();
            Console.WriteLine("Enter a superhero:");
            string superheroName = Console.ReadLine();
            Console.WriteLine("Enter a country:");
            string countryName = Console.ReadLine();
            Console.WriteLine("Enter a dessert:");
            string dessertName = Console.ReadLine();
            Console.WriteLine("Enter a year:");
            string yearName = Console.ReadLine();



            // The template for the story:
            string story = $"This morning {userName} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animalName}s were protesting to keep {foodName} in stores. They began to {verbName} to the rhythm of the {firstNoun}, which made all the {fruitName}s very {thirdAdjective}. Concerned, {userName} texted {superheroName}, who flew {userName} to {countryName} and dropped {userName} in a puddle of frozen {dessertName}. {userName} woke up in the year {yearName}, in a world where {secondNoun}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);
        }
    }
}
