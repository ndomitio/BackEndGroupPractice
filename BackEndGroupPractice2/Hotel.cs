using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGroupPractice2
{
    public class Hotel : Beach
    {
        //fields

        private double UserShoe;

        //properties

            public double userShoe { get; set; }
        

        //constructors

        public Hotel()
        {
            //default constructor
        }

        public Hotel(double ShoeSize1)
        {
            this.ShoeSize1 = ShoeSize1;
        }
        //methods

        public string HotelPick(double ShoeSize1, string beachPick)
        {
            if ((beachPick == "Venice") && (ShoeSize1 >= 8))
            {
                return "Hilton";
            }

            if ((beachPick == "Venice") && (ShoeSize1 < 8))
            {
                return "Mariott";
            }
            if ((beachPick == "Redondo") && (ShoeSize1 >= 8))
            {
                return "Red Roof Inn";
            }
            if ((beachPick == "Redono") && (ShoeSize1 < 8))
            {
                return "Hyatt Place";
            }
            if ((beachPick == "Jersey Shore") && (ShoeSize1 >= 8))
            {
                return "Aloft";
            }
            if ((beachPick == "Jersey Shore") && (ShoeSize1 < 8))
            {
                return "Embassy Suites";
            }
            if ((beachPick == "Champagne") && (ShoeSize1 >= 8))
            {
                return "Best Western";
            }
            if ((beachPick == "Champagne") && (ShoeSize1 < 8))
            {
                return "Westin";
            }
            if ((beachPick == "Bondi") && (ShoeSize1 >= 8))
            {
                return "Hampton";
            }
            if ((beachPick == "Bondi") && (ShoeSize1 < 8))
            {
                return "Holiday Inn";
            }
            else
                return " ";
        }

    }
}
