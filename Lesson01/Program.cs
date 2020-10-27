using System;

namespace Lesson01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Myage();
            Myage1();
            Rectangle();
            Triangle();
            cercle();
            CurrentDate();
            CurrentTime();
            Datein10y();
            DateinXy();
            FutureBirthday();

        }

        private static void Myage()
        {
            Console.WriteLine("How old are you ?");
            string age = Console.ReadLine();

            try
            {
                int age1 = int.Parse(age);

                int age10 = age1 + 10;
                Console.Write("Your age in 10 years will be " + age10);
            }

            catch
            {
                Console.WriteLine("Error");
            }
        }

        private static void Myage1()
        {
            Console.Write("How old are you ?");
            string age = Console.ReadLine();
            bool parseresult = int.TryParse(age, out int age1);
            if (parseresult)
            {
                int age10 = age1 + 10;
                Console.WriteLine("Your age in 10 years will be" + age10);
            }

            else
            {
                Console.WriteLine("error");
            }
        }

        private static void Rectangle()
        {
            Console.WriteLine("Please enter the length of side 1 : ");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of side 2 : ");
            int side2 = int.Parse(Console.ReadLine());


            int area = side1 * side2;
            int perimeter = 2 * side1 + 2 * side2;
        }

        private static void Triangle()
        {
            Console.WriteLine("Please enter side1 :");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side2 :");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side3 :");
            int side3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter height :");
            int height = int.Parse(Console.ReadLine());



            int perimeter = side1 + side2 + side3;
            int area = side1 * height / 2;

        }

        private static void cercle()
        {
            Console.WriteLine("Please enter the radius of the cercle :");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the cercle is" + (radius ^ 2) * Math.PI);
            Console.WriteLine("The perimeter of the cercle is " + 2 * radius * Math.PI);

        }

        private static void CurrentDate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString());
        }

        private static void CurrentTime()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToShortTimeString());
        }

        private static void Datein10y()
        {
            DateTime datein10y = DateTime.Now.AddYears(10);
            Console.WriteLine(datein10y);
        }

        private static void DateinXy()
        {
            Console.WriteLine("Please enter the number of years :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddYears(x));
        }

        private static void FutureBirthday()
        {
            Console.WriteLine("How old are you ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your future age ?");
            int futureage = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birthday month ?");
            int bdmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birthday day of month ?");
            int bdday = int.Parse(Console.ReadLine());

            int difference = age + futureage;
            int futureyear = DateTime.Now.Year + difference;
            var futurebdday = new DateTime(futureyear, bdmonth, bdday);
        }
}

