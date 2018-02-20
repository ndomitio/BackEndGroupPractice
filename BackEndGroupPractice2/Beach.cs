using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndGroupPractice2
{
    public abstract class Beach
    {
        //fields

        private string eyeColor;
        private double shoeSize1;
        private bool shoeSize2;
        //properties

        public double ShoeSize1 { get; set; }
        public string EyeColor { get; set; }
        public bool ShoeSize2 { get; set; }
        //constructors

        public Beach()
        { }

        //methods

        public virtual string ChangeEyeColorToInt()
        {
            Console.WriteLine("What color are your eyes?");
            EyeColor = Console.ReadLine();
            if (EyeColor == "blue")
                return "1";
            if (EyeColor == "green")
                return "2";
            if (EyeColor == "brown")
                return "3";
            if (EyeColor == "hazel")
                return "4";
            else
                return "5";
        }
    }

}
