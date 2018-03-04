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



            double ShoeSize1 = double.Parse(Console.ReadLine());

            Console.WriteLine("You are going to " + beachChoice + " and staying at the " + MyHotel.HotelPick(ShoeSize1, beachChoice) + " hotel");



        }
    }
}
