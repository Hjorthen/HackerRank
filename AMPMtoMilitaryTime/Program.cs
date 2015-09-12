using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMPMtoMilitaryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(':');
                string period = tokens[2].Substring(2, 2);
                int hours = Convert.ToInt32(tokens[0]);
                int minutes = Convert.ToInt32(tokens[1]);
                int seconds = Convert.ToInt32(tokens[2].Substring(0, 2));
                if(hours >= 12)
                {
                    if( period== "AM")
                    {
                        hours -= 12;
                    }
                }
                else if (period == "PM")
                {
                    hours += 12;
                }
                Console.WriteLine(string.Format("{0}:{1}:{2}", hours.ToString("D2"), minutes.ToString("D2"), seconds.ToString("D2")));
            }
            Console.ReadLine();
        }
    }
}
