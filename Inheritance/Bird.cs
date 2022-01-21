using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird(string name, string color)
        {
            _name = name;
            _featherColor = color;
        }

        private string _name = "Tweetie";
        private string _featherColor = "white";
        private string _animalClassName = "Aves";

        public string Name
        {
            get { return _name; }
        }

        public string FeatherColor
        {
            get { return _featherColor; }
        }

        public string AnimalClassName
        {
            get { return _animalClassName; }
        }

        public void Fly()
        {
            Console.WriteLine("*flies into the sunset*");
        }
    }
}
