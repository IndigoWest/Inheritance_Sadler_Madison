// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Text namespace needed to use Console class
using System.Text;

// My collection of classes for the program
namespace Inheritance_Sadler_Madison
{
    // Main class for RPG.cs and inherits from Game.cs
    class RPG : Game
    {
        // The Main method is executed the the application starts
        // Initializes a public RPG method with two string parameters: esrbParam and titleParam, and explicitly shows inheritance from the base class
        public RPG(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            // States Title is titleParam
            Title = titleParam;
            // States Esrb is esrbParam
            Esrb = esrbParam;
        }
        // Initializes a public string Describe method and overrides it
        public override string Describe()
        {
            // returns text {Title} is an RPG game rated {Esrb}
            return $"{Title} is an RPG game rated {Esrb}.";
        }
    }
}
