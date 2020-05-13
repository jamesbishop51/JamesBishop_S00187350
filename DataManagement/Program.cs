using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JamesBishop_S00187350;
using System.Data.Entity;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneData db = new PhoneData();
            

            using (db)
            {
                Phone p1 = new Phone() { PhoneId = 1, Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/s20.jpg"  };
                Phone p2 = new Phone() { PhoneId = 3, Name = "iPhone 11", Price = 600, OperatingSystem = "IOS", OS_Image = "/images/apple.png", Phone_Image = "/images/iphone11.png" };

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("added the phones to the database");

                db.SaveChanges();

                Console.WriteLine("saved to database");

            }


        }
    }
}
