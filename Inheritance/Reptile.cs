using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile(string name, string color)
        {
            _name = name;
            _scaleColor = color;
        }

        private string _name = "Snake";
        private string _scaleColor = "black";
        private string _animalClassName = "Reptilia";

        public string Name
        {
            get { return _name; }
        }

        public string ScaleColor
        {
            get { return _scaleColor; }
        }

        public string AnimalClassName
        {
            get { return _animalClassName; }
        }

        public void Slither()
        {
            Console.WriteLine("*slithering sounds*");
        }
    }
}
