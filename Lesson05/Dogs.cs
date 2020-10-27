using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    class Dogs
    {
        private string name;
        private string breed;

        public Dogs()
        {
        }

        public string Name
        {
            get;
            set;
        }

        public string Breed
        {
            get;
            set;
        }

        public void Bark()
        {
            Console.WriteLine("Woof Woof!");
        }

        
    }
}
