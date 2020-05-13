using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesBishop_S00187350
{
    class Phone
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }



        static void IncreasePrice(double Percentage, double Price)
        {
            double increase;
            Price = 500;

            Percentage = Percentage / 100;

            increase = Price * Percentage;

            Price = Price + increase;



        }

    }

}
