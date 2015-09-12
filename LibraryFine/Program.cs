using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFine
{
    class Date
    {
        public int Day = 0;
        public int Month = 0;
        public int Year = 0;
        public Date(int d, int h, int y)
        {
            Day = d;
            Month = h;
            Year = y;
        }

        public static Date operator-(Date d2, Date d1)
        {
            return new Date(d2.Day - d1.Day, d2.Month - d1.Month, d2.Year - d1.Year);
        }
        public static bool operator<=(Date d1, Date d2)
        {
            return d2 >= d1;
        }
        public static bool operator>=(Date d1, Date d2)
        {
            //Console.WriteLine(d1 + " " + d2);

            //d2=00 0 2013
            //d1=00 0 2015

            //d2=15 6 2015
            //d1=14 6 2015

            //d2=28 2 2015
            //d1=15 4 2015
            if (d1.Year > d2.Year) //if d1's year is higher, then the date is definitely later
            {
                return true;
            }
            else if(d1.Year == d2.Year) //if the years are equals, then we gotta test the months:
            {
                if (d1.Month > d2.Month) //if d1's month is higher, then the date it later
                {
                    return true;
                }
                else if (d1.Day >= d2.Day && d1.Month == d2.Month) //if the months are the same and d1 is higher than or equal to d2 then the date might be later, but not earlier
                {
                    return true;
                }
            }
            return false; 
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", Day.ToString("D2"), Month.ToString("D2"), Year.ToString("D4"));
        }
    }

    class Solution
    {
        static Date ExtractDate(string s)
        {
            string[] tokens = s.Split(' ');
            int[] retArr = new int[tokens.Length];
            for (int i = 0; i < 3; i++)
            {
                retArr[i] = Convert.ToInt32(tokens[i]);
            }
            return new Date(retArr[0], retArr[1], retArr[2]);
        }

        static void Main(string[] args)
        {

         
                string line = Console.ReadLine();
               // string line = rng.Next(1, 32).ToString() + " " + rng.Next(1, 12).ToString() + " " + rng.Next(1, 1).ToString(); 
                Date todaysDate = ExtractDate(line);

                //line = rng.Next(1, 32).ToString() + " " + rng.Next(1, 12).ToString() + " " + rng.Next(1, 1).ToString();
                line = Console.ReadLine();
                Date returnDate = ExtractDate(line);

                if (returnDate >= todaysDate)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Date dateDifference = returnDate - todaysDate;
                    //Console.WriteLine(dateDifference.ToString());
                    if (dateDifference.Year == 0)
                    {
                        if (dateDifference.Month == 0)
                        {
                            Console.WriteLine(15 * Math.Abs(dateDifference.Day));
                        }
                        else
                        {
                            Console.WriteLine(500 * Math.Abs(dateDifference.Month));
                        }
                    }
                    else
                    {
                        Console.WriteLine(10000);
                    } 
                    
                    
                }
            
        }
        
    }
}
