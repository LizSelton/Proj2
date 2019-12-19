using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LINQ
{
    class Program
    {
        class LunchCost
        {
            public int LunchID { get; set; }
            public String LunchName { get; set; }
            public Double Cost { get; set; }
        }//class LunchCost
        static void Main(string[] args)
        {
            LunchCost[] lunchArray = {
                new LunchCost() { LunchID = 1, LunchName = "Hamburger", Cost = 3.00},
                new LunchCost() { LunchID = 2, LunchName = "Fried Chicken", Cost = 2.00},
                new LunchCost() { LunchID = 3, LunchName = "Green Bean Casserole", Cost = 5.00},
                new LunchCost() { LunchID = 4, LunchName = "Mashed Potatoes", Cost = 2.00},
                new LunchCost() { LunchID = 5, LunchName = "Chef Salad", Cost = 3.00},
                new LunchCost() { LunchID = 6, LunchName = "Beef Taco", Cost = 1.00},

            };

            var lunch = from l in lunchArray
                        where l.Cost > 2.00 && l.Cost < 5.00
                        select l;

            foreach (var lunches in lunch)
            {
                WriteLine("My lunch items between $2.00 and $5.00 are : " + lunches.LunchName);
            }



            var groups = from l in lunchArray
                         orderby l.Cost
                         group l by l.Cost;

            foreach (var lun in groups)
            {
                Console.WriteLine("**************** Cost group: ${0}", lun.Key);
                foreach (LunchCost l in lun)
                {
                    WriteLine("Lunch name: {0}", l.LunchName +"\n");

                }
            }


            var letterH = from h in lunchArray
                          where h.LunchName.StartsWith("H")
                          select h;

            foreach (var lun in letterH)
            {
                WriteLine("My lunch items that start with H are: " + lun.LunchName + " and it costs $" + lun.Cost +"\n");
            }
        }
    }
}

