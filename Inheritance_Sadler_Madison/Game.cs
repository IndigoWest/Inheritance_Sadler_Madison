// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Text namespace needed to use Console class
using System.Text;

// My collection of classes for this project
namespace Inheritance_Sadler_Madison
{
    // Main class for Game.cs and is labeled as abstract
    abstract class Game
    {
        // The Main method is executed when the application starts
        // Creates a public string called Esrb
        public string Esrb
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }

        // Creates a public string called Title
        public string Title
        {
            // Sets a getter
            get;
            // Sets a setter
            set;
        }
        // Creates a public Game method with two string parameters: esrbParam and titleParam
        public Game(string esrbParam, string titleParam)
        {
            // States Esrb is esrbParam
            Esrb = esrbParam;
            // States Title is titleParam
            Title = titleParam;
        }
        // Creates a public void PlayGame method
        public void PlayGame()
        {
            // Prints to console {Title} is Starting...
            Console.WriteLine($"{Title} is Starting...");
        }

        //Creates a public abstring string Describe() method
        public abstract string Describe();
    }
}
