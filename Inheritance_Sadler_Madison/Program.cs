// System namespace needed to use Console class
using System;

// My collection of classes for this project
namespace Inheritance_Sadler_Madison
{
    // Main class for Program.cs
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Creates new RPG under RPG myRPG and sets "M" as the esrb rating and "Skyrim" as the title
            RPG myRPG = new RPG("M", "Skyrim");

            // Prints to console the Describe method text
            Console.WriteLine(myRPG.Describe());
            // Calls the PlayGame method for myRPG
            myRPG.PlayGame();

            // Creats new RPG under RPG undertale and sets "PG" as the esrb rating and "Undertale" as the title
            RPG undertale = new RPG("PG", "Undertale");

            // Prints to console the Describe method text
            Console.WriteLine(undertale.Describe());
            // Calls the PlayGame method for undertale
            undertale.PlayGame();
        }
    }
}
