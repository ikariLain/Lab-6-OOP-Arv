using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    // The Program class contains the Main method where the execution begins.
    internal class Program
    {
        // Main method - Entry point for the application
        static void Main(string[] args)
        {
            // Initialize objects for Bulldog and Chihuahua with their respective properties
            // Bulldog object: Name, Age, Color, Location, Weight, Country, Breed
            Bulldog bulldog = new Bulldog("Rex", 7, "Brun", "Stockholm", 25.0, "Sverige", "Bulldog");

            // Chihuahua object: Name, Age, Color, Location, Weight, Country, Breed, Size
            Chihuahua chihuahua = new Chihuahua("Tiny", 3, "Vit", "Göteborg", 5.0, "Kattala", "Chihuahua", "Kort");

            // Display Bulldog's information
            Console.WriteLine("Information om Bulldog:");
            bulldog.ShowInfo();      // Calls ShowInfo method to display Bulldog's details
            bulldog.makeSound();     // Calls makeSound method to make Bulldog's sound
            bulldog.AmountShowerd(3); // Calls AmountShowerd method with parameter 3 (showing 3 times) 

            Console.WriteLine();     // Adds an empty line for better output formatting

            // Display Chihuahua's information
            Console.WriteLine("Information om Chihuahua:");
            chihuahua.ShowInfo();      // Calls ShowInfo method to display Chihuahua's details
            chihuahua.makeSound();     // Calls makeSound method to make Chihuahua's sound
            chihuahua.annoyingMeter(30); // Calls annoyingMeter method with parameter 30 (measuring how annoying it is)

            // Wait for user input before closing the console window
            Console.ReadLine(); 
     
