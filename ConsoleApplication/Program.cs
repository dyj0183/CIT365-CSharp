using System;

namespace ConsoleApplication
{
    class Program
    {
        public void getDaysBetweenTodayAndChristmas()
        {
            DateTime today = DateTime.Now;
            DateTime christmas = Convert.ToDateTime("12/25/2021");
            int numOfDays = (christmas - today).Days;
            Console.WriteLine($"There are {numOfDays} days between today and Christmas.");
        }

        public void getTodayDate()
        {
            DateTime todayDate = DateTime.Now;
            Console.WriteLine($"Today's date is {todayDate.ToString("MMMM dd, yyyy")}");
        }

        public void getPersonInfo()
        {
            string name = "Yu-Chun";
            string location = "Rexburg";
            Console.WriteLine($"Hello, my name is {name}.");
            Console.WriteLine($"I am currently living in {location}!");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.getPersonInfo();
            p.getTodayDate();
            p.getDaysBetweenTodayAndChristmas();

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please enter the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press 'Enter' to exit the process!");
            // it makes the program wait for a key press and it prevents the screen from being closed until a key is pressed
            while(Console.ReadKey().Key != ConsoleKey.Enter)
            {
                // if the user doesn't press "Enter", the screen won't be closed and this loop will keep going
            }
        }
    }
}
