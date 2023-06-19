using System.Text.RegularExpressions;

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
            string userName = GetUserInput("Enter your name:");
            string firstAdjective = GetUserInput("Enter an adjective:");
            string secondAdjective = GetUserInput("Enter a second adjective:");
            string thirdAdjective = GetUserInput("Enter a third adjective:");
            string verbName = GetUserInput("Enter a verb:");
            string firstNoun = GetUserInput("Enter a first noun:");
            string secondNoun = GetUserInput("Enter a second noun:");
            string animalName = GetUserInput("Enter an animal:");
            string foodName = GetUserInput("Enter a food:");
            string fruitName = GetUserInput("Enter a fruit:");
            string superheroName = GetUserInput("Enter a superhero:");
            string countryName = GetUserInput("Enter a country:");
            string dessertName = GetUserInput("Enter a dessert:");
            string yearName = GetUserInput("Enter a year:", validateYear: true);

            // The template for the story:
            string story = GenerateMadLibsStory(userName, firstAdjective, secondAdjective, thirdAdjective, verbName, firstNoun, secondNoun, animalName, foodName, fruitName, superheroName, countryName, dessertName, yearName);

            // Print the story:
            Console.WriteLine(story);
        }

        static string GetUserInput(string prompt, bool validateYear = false)
        {
            Console.WriteLine(prompt);
            string? userInput = Console.ReadLine()?.Trim();

            // Validate input
            while (string.IsNullOrEmpty(userInput) || (validateYear && !IsValidYear(userInput)) ||
                   (!validateYear && !IsAlphabetic(userInput)))
            {
                Console.WriteLine(validateYear ? "Invalid year. Please enter a valid year (e.g., 2023):" :
                                                  $"Invalid input. Please enter alphabetic characters only.\n{prompt}");
                userInput = Console.ReadLine()?.Trim();
            }

            return userInput;
        }

        static string GenerateMadLibsStory(string userName, string firstAdjective, string secondAdjective, string thirdAdjective, string verbName, string firstNoun, string secondNoun, string animalName, string foodName, string fruitName, string superheroName, string countryName, string dessertName, string yearName)
        {
            string secondAdjectiveArticle = GetArticle(secondAdjective);
            return $"This morning {userName} woke up feeling {firstAdjective}. 'It is going to be {secondAdjectiveArticle} {secondAdjective} day!' Outside, a bunch of {animalName}s were protesting to keep {foodName} in stores. They began to {verbName} to the rhythm of the {firstNoun}, which made all the {fruitName}s very {thirdAdjective}. Concerned, {userName} texted {superheroName}, who flew {userName} to {countryName} and dropped {userName} in a puddle of frozen {dessertName}. {userName} woke up in the year {yearName}, in a world where {secondNoun}s ruled the world.";
        }

        static bool IsAlphabetic(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
        }

        static bool IsValidYear(string input)
        {
            return int.TryParse(input, out int year) && input.Length == 4 && year >= 1900 && year <= DateTime.Now.Year;
        }

        static string GetArticle(string word)
        {
            char firstChar = word.ToLower()[0];

            // Check if the word starts with a vowel
            if (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u')
            {
                return "an";
            }

            return "a";
        }
    }
}