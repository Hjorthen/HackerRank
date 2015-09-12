using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine()); //Gets the number of test cases
            for (int i = 0; i < T; i++)
            {
                string[] NK = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(NK[0]);
                int K = Convert.ToInt32(NK[1]);

                string[] tokens = Console.ReadLine().Split(' ');
                int studentsEnteredBeforeClass = 0;
                foreach(string s in tokens)
                {
                    if (Convert.ToInt32(s) <= 0)
                        ++studentsEnteredBeforeClass;
                }
                if(studentsEnteredBeforeClass<K)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}
