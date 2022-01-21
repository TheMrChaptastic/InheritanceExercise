using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Animal
    {
        private bool _isAnAnimal = true;
        private bool _hasOrgans = true;
        private string _kingdom = "Animalia";

        public bool IsAnAnimal
        {
            get { return _isAnAnimal; }
        }

        public bool HasOrgans 
        { 
            get { return _hasOrgans; } 
        } 

        public string Kingdom
        {
            get { return _kingdom; }
        }

    }
}
