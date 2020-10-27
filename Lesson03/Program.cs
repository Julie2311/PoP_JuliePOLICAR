using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle();
            Sum();
            Sport();

            Console.WriteLine("Please enter the number of the day (1-7) ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the hour of the day (0-23) ");
            int h = int.Parse(Console.ReadLine());

            Greetings(d, h);

            Console.WriteLine("Please enter your name");
            string n = Console.ReadLine();
        }

        private static void Triangle()
        {
            Console.WriteLine("Please enter side a");
            int sidea = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side b");
            int sideb = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side c");
            int sidec = int.Parse(Console.ReadLine());
            TwoSides(sidea, sideb, sidec);

            ThreeSides(sidea, sideb, sidec);

        }

        private static bool TwoSides(int sidea, int sideb, int sidec)
        {
            bool result;

            if (sidea == sideb || sidea == sidec || sideb == sidec)
            {
                result = true;
                return result;
            }
            else return false;
        }

        private static bool ThreeSides(int sidea, int sideb, int sidec)
        {
            bool result1;

            if (sidea == sideb && sideb == sidec)
            {
                result1 = true;
                return result1;
            }
            else return false;
        }

        private static void Sum()
        {
            Console.WriteLine("Please enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int b = int.Parse(Console.ReadLine());

            if (a > 10 && a < 20 && b > 10 && b < 20)
            {
                Console.WriteLine(a + b);
            }
        }

        /*private static void Random ()
        {
            int[] t=new int [10];
            for(int i=0; i<=t.Length; i++)
            {
                
            }
        }

        private static void Numbers()
        {

        }*/

        private static void Sport()
        {
            Console.WriteLine("Please enter your height");
            int h = int.Parse(Console.ReadLine());
            if (h > 190)
            {
                Console.WriteLine("You should choose basketball!");
            }

            if (h > 175 && h < 190)
            {
                Console.WriteLine("You should choose athletic!");
            }

            if (h < 175)
            {
                Console.WriteLine("You should choose horse riding!");
            }
        }

        private static void Greetings(int d, int h)
        {

            string hour = HourInString(h);
            string day = Dayinstring(d);

            int diff = 6 - d;
            string we = MomentOfTheWeek(diff);


            Console.WriteLine(hour + " It is a lovely " + day + " today. " + we + " days");

        }

        private static string MomentOfTheWeek(int diff)
        {
            if (diff <= 0) return "Weekend is here! ";
            if (diff > 0)
            {
                return $"The weekend is in {diff} ";
            }
            else return "Unknown";
        }

        private static string HourInString(int h)
        {
            if (h < 12) return "Good morning !";
            if (h > 12) return "Good afternoon!";

            else return "Unknown";
        }
        private static string Dayinstring(int d)
        {

            if (d == 1) { return "Monday"; }
            if (d == 2) { return "Tuesday"; }
            if (d == 3) { return "Wednesday"; }
            if (d == 4) { return "Thursday"; }
            if (d == 5) { return "Friday"; }
            if (d == 6) { return "Saturday"; }
            if (d == 7) { return "Sunday"; }

            else return "Unknown";
        }

        private static void FormValidation()
        {
            NameValidation()
        }

        private static bool NameValidation(string n)
        {

            if (n.Length < 100 && n != null) return true;
            else
            {
                return false;
            }

        }
    }
}
