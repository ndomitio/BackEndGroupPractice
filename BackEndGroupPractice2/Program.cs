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

            RentalCar MyCar = new RentalCar();

            string beachChoice = NewBeach.ChangeEyeColorToInt();



            double ShoeSize1 = double.Parse(Console.ReadLine());

            double CarChoice1 = MyCar.TurnBeachtoInt(beachChoice, ShoeSize1);

            Console.WriteLine("You are going to " + beachChoice + ", staying at the " + MyHotel.HotelPick(ShoeSize1, beachChoice) + " hotel and driving a " + MyCar.RentalCarType(CarChoice1));



        }
    }
}
