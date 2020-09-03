using System;

namespace Project_Learn_C_Sharp__Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program does
            the following...

            Author: Tristian Neely 
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs is starting!");

            // Give the Mad Lib a title:
            string title = "MAD LIBS!";
            Console.WriteLine(title);

            // Define user input and variables:

            // 1
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            // 2
            Console.Write("Enter a First adjective: ");
            string adj1 = Console.ReadLine();

            // 3 
            Console.Write("Enter a Second adjective: ");
            string adj2 = Console.ReadLine();

            // 4 

            Console.Write("Enter a Animal: ");
            string animal = Console.ReadLine();

            // 5

            Console.Write("Enter a Food: ");
            string food = Console.ReadLine();

            // 6

            Console.Write("Enter a Verb: ");
            string verb = Console.ReadLine();

            // 7

            Console.Write("Enter a First noun: ");
            string noun1 = Console.ReadLine();

            // 8

            Console.Write("Enter a Fruit: ");
            string fruit = Console.ReadLine();

            // 9

            Console.Write("Enter a Third adjective: ");
            string adj3 = Console.ReadLine();


            // 10

           // Console.Write("Enter a name: ");
            // string name = Console.ReadLine();

            // 11

            Console.Write("Enter a Superhero: ");
            string superhero = Console.ReadLine();

            // 12

            // Console.Write("Enter a name: ");
            // string name = Console.ReadLine();

            // 13

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            // 14


            // Console.Write("Enter a name: ");
            // string name = Console.ReadLine();

            // 15

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            // 16

            // Console.Write("Enter a name: ");
            // string name = Console.ReadLine();

            // 17

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();

            // 18


            Console.Write("Enter a Second noun: ");
            string noun2 = Console.ReadLine();




            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);











        }
    }
}
