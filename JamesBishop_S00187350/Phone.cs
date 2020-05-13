using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace JamesBishop_S00187350
{
    public class Phone
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }
        public int PhoneId { get; set; }

        //public override string ToString()
        //{
        //    return string.Format($"{Name}");

        //}
        public static void IncreasePrice(double Percentage)
        {
            double increase;
           double Price = 500;

            Percentage = Percentage / 100;

            increase = Price * Percentage;

            Price = Price + increase;



       }

    }

    public class PhoneData : DbContext
    {

        public PhoneData() : base("MyPhoneDate") { }

        public DbSet<Phone> Phones { get; set; }
    }

}
