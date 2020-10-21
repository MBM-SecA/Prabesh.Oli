using System;
using System.Linq;

namespace LINQ.Restriction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7, 8, 9, 10 };
            //fetch number which are greater than 50

            //uisng method syntax -{lemda expression is used}
            var numberGreaterthan50 = numbers.Where(x => x > 50);

            // using query sql syntax - query expressionfff
            var numberGreaterthanfifty = from num in numbers
                                         where num > 50
                                         select num;

            string[] names = { "ram", "ramesh", "roman", "haris", "riwas" };
            var startWithRandlengthgreaterThan3 = from name in names
                                                  where name.Length > 3 && name.StartsWith("r")
                                                  select name;
             foreach(var y in names){
                 Console.WriteLine(names);
             }

        }
    }
}
