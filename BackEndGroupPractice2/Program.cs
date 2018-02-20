using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGroupPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            BeachDestination NewBeach = new BeachDestination(string.Empty);

            Hotel MyHotel = new Hotel();

            string beachChoice = NewBeach.ChangeEyeColorToInt();
            
            Console.WriteLine("What size shoe are you?");

            double userChoice = double.Parse(Console.ReadLine());

            Console.WriteLine("You are going to " + beachChoice + " and staying at the " + MyHotel.HotelPick(userChoice, beachChoice) + " hotel");


        }
    }
}
