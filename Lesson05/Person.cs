using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public Person(string name, int age) : this (name,  age, null)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is empty !");
                }

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(age<1 || age>100)
                {
                    throw new ArgumentOutOfRangeException("Age might be 1-100 !");
                }
                age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (email != null && !email.Contains("@"))
                {
                    throw new FormatException("Not the right format");
                }
                    email = value;
            }
        }

        public override string ToString()
        {
            return $"Person {name}, age: {age}, email : {email}";
        }
    }
}
