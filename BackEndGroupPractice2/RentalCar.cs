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
   
        //properties

        public int BeachNumber { get; set; }
        public double CarNumber { get; set; }
        public string CarPick { get; set; }

        //constructors

        public RentalCar()
        {
            //default constructor
        }

        //methods

        public double TurnBeachtoInt(string beach, double ShoeSize1)
        {

            if (beach == "Venice")
            {
                BeachNumber = 1;
            }
            if (beach == "Redondo")
            {
                BeachNumber = 2;
            }
            if (beach == "Jersey Shore")
            {
                BeachNumber = 3;
            }
            if (beach == "Champagne")
            {
                BeachNumber = 4;
            }
            if (beach == "Bondi")
            {
                BeachNumber = 5;
            }
            CarNumber = (BeachNumber + ShoeSize1);
            //take return and then in second method run conditional for car choice and return car choice to console and 
            //incorporate into consolewriteline on program class
            return BeachNumber;
        }
    }
}
