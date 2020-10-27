using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    class Cats: Animals
    {
        private string name;

        public Cats(string name, string owner)
        {
            Name = name;
            Owner = owner;
        }

        public Cats(string name)
        {
            this.name = name;
        }

        public Cats()
        {
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Can must have name!!!");
                }
                name = value;
            }
        }

        public string Owner
        {
            get;
            set;
        }
    }
}
