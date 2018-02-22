using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGroupPractice2
{
    public class BeachDestination : Beach
    {
        //fields
        private string beach;
        //properties
        public string Beach { get; set; }
        //constructors
        public BeachDestination()
        {

        }

        public BeachDestination(string Eyecolor)
        {
            this.EyeColor = Eyecolor;

        }

        //methods

        public override string ChangeEyeColorToInt()
        {
            string eyeNumber = base.ChangeEyeColorToInt();
            ChangeIntToBeach(eyeNumber);
            Console.WriteLine("What size shoe are you?");
            

            return beach;
            
        }

        public string ChangeIntToBeach(string eyeNumber)
        {
            if (eyeNumber == "1")
            {
                beach = "Venice";
                return beach;
            }
            if (eyeNumber == "2")
            {
                beach = "Redondo";
                return beach;
            }
            if (eyeNumber == "3")
            {
                beach = "Jersey Shore";
                return beach;
            }
            if (eyeNumber == "4")
            {
                beach = "Champagne";
                return beach;
            }
            if (eyeNumber == "5")
            {
                beach = "Bondi";
                return beach;
            }
            else return " ";

        }
    }
}
