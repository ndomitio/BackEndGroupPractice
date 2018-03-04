using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGroupPractice2
{
    class RentalCar : Hotel
    {
        //fields
        private int beachNumber;
        private double carNumber;
        private string carPick;
        private double carChoice1;

        //properties

        public double CarChoice1 { get; set; }
        public int BeachNumber { get; set; }
        public double CarNumber { get; set; }
        public string CarPick { get; set; }

        //constructors

        public RentalCar()
        {
            //default constructor
        }


        public RentalCar(string carPick)
        {
            this.carPick = CarPick;
        }

        //methods
        public string RentalCarType(double carNum)
        {
            if (carNum == 8.0)
            {
                carPick = "Toyota";
                return carPick;
            }
            if (carNum == 9.0)
            {
                carPick = "Honda";
                return carPick;
            }
            if (carNum == 10.0)
            {
                carPick = "Ford";
                return carPick;
            }
            if (carNum == 11.0)
            {
                carPick = "BMW";
                return carPick;
            }
            if (carNum == 12.0)
            {
                carPick = "Audi";
                return carPick;
            }
            if (carNum == 13.0)
            {
                carPick = "Tesla";
                return carPick;
            }
            if (carNum == 14.0)
            {
                carPick = "'77 Bronco";
                return carPick;
            }
            if (carNum == 15.0)
            {
                carPick = "Jeep";
                return carPick;
            }
            if (carNum == 16.0)
            {
                carPick = "Maserati";
                return carPick;
            }
            if (carNum == 17.0)
            {
                carPick = "Lexus";
                return carPick;
            }
            if (carNum == 18.0)
            {
                carPick = "Delorean";
                return carPick;
            }
            if (carNum == 19.0)
            {
                carPick = "Pinto";
                return carPick;
            }
            if (carNum == 20.0)
            {
                carPick = "Ferrari";
                return carPick;
            }
            else carPick = "Kia";
            return carPick;
        }



        public double TurnBeachtoInt(string beach, double ShoeSize1)
        {

            if (beach == "Venice")
            {
                beachNumber = 1;
            }
            if (beach == "Redondo")
            {
                beachNumber = 2;
            }
            if (beach == "Jersey Shore")
            {
                beachNumber = 3;
            }
            if (beach == "Champagne")
            {
                beachNumber = 4;
            }
            if (beach == "Bondi")
            {
                beachNumber = 5;
            }
            carNumber = (beachNumber + ShoeSize1);
            //take return and then in second method run conditional for car choice and return car choice to console and 
            //incorporate into consolewriteline on program class
            return carNumber;
        }
    }
}
