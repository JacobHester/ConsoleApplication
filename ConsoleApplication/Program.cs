using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName, location, yesOrNo;

            Console.Write("Please enter your full name: ");
            fullName = Console.ReadLine();

            Console.Write("Please enter your location: ");
            location = Console.ReadLine();

            Console.WriteLine($"My name is { fullName }, I am from { location }");

            Console.Write("Do you want to know how many days till Christmas? (y/n): ");
            yesOrNo = Console.ReadLine();

            if (yesOrNo == "y")
            {

            }
            else if (yesOrNo == "n") {
                Console.WriteLine("Too bad"); //Hah
            } else {
                Console.WriteLine("You didn't put 'y' or 'n' soooo 'y' was assumed");
            }

            //Days Till Christmas//

            var today = DateTime.Now; //Todays Date
            var christmasYear = 0; //To check what year we should use for the next Christmas

            if (today.Month == 12 && today.Day > 24)
            {
                christmasYear = today.Year + 1; //Christmas is passed and the next year will be used
            } else {
                christmasYear = today.Year; //Christmas hasn't occured
            }
            var christmas = new DateTime(christmasYear, 12, 25);

            var daysTillChristmas = christmas.Date - today.Date;

            Console.WriteLine($"Days till Christmas: { daysTillChristmas }");

            //Area//

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Type in the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Type in the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");            Console.WriteLine("Press any key to exit");
            Console.ReadKey();





        }
    }
}
