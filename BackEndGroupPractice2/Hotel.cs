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

        //properties

        //constructors

        public Hotel()
        {
            //default constructor
        }
        //methods

        public string HotelPick(double userSize, string beachPick)
        {
            if ((beachPick == "Venice") && (userSize >= 8))
            {
                return "Hilton";
            }

            if ((beachPick == "Venice") && (userSize < 8))
            {
                return "Mariott";
            }
            if ((beachPick == "Redondo") && (userSize >= 8))
            {
                return "Red Roof Inn";
            }
            if ((beachPick == "Redono") && (userSize< 8))
            {
                return "Hyatt Place";
            }
            if ((beachPick == "Jersey Shore") && (userSize>=8))
            {
                return "Aloft";
            }
            if ((beachPick == "Jersey Shore") && (userSize < 8))
            {
                return "Embassy Suites";
            }
            if ((beachPick == "Champagne") && (userSize >= 8))
            {
                return "Best Western";
            }
            if ((beachPick == "Champagne") && (userSize < 8))
            {
                return "Westin";
            }
            if ((beachPick == "Bondi") && (userSize >= 8))
            {
                return "Hampton";
            }
            if ((beachPick == "Bondi") && (userSize < 8))
            {
                return "Holiday Inn";
            }
            else
                return " ";
        }

    }
}
