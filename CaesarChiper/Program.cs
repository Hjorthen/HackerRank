using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarChiper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine(); //We don't need to know the lenght of the input
            StringBuilder encoder = new StringBuilder(Console.ReadLine());
            int key = Convert.ToInt32(Console.ReadLine());
            key = key % 26;
            for (int i = 0; i < encoder.Length; i++)
            {
                char c = encoder[i];
                if (Char.IsLetter(c))
                {


                    int overflow = 0;
                    if (Char.IsUpper(c))
                    {
                        overflow = (c + key) - (int)'Z';
                    }
                    else if (Char.IsLower(c))
                    {
                        overflow = (c + key) - (int)'z';
                    }
                    if (overflow > 0)
                    {
                        overflow -= 1;
                        if (Char.IsUpper(c))
                        {
                            encoder[i] = (char)(((int)'A') + overflow);
                        }
                        else
                        {
                            encoder[i] = (char)(((int)'a') + overflow);
                        }

                    }
                    else
                    {
                        encoder[i] = (char)(((int)c) + key);
                    }
                }


            }
            Console.WriteLine(encoder);
            Console.ReadLine();

        }
    }
}
