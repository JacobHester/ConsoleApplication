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

            Console.WriteLine($"{ fullName } lives in { location }");

            Console.Write("Do you want to know how many days till Christmas? (y/n)");
            yesOrNo = Console.ReadLine();

            if (yesOrNo == "y")
            {

            }
            else if (yesOrNo == "n") {

            } else {
                Console.Write("You didn't put 'y' or 'n' soooo the program closes");
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

            //Area//

            double width, height, woodLength, glassArea;
            string widthString, heightString;





        }
    }
}
