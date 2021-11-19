using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "012345678";
            char[] newarray = new char[s.Length];


            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0 && (s.Length-1)%2==0 && i== s.Length-1)
                {
                    newarray[i] = s[i];
                }
                else if(i % 2 == 0 && i != s.Length - 1)
                {
                    newarray[i] = s[i + 1];
                }
                else
                {
                    newarray[i] = s[i - 1];
                }

            }
            
         


            Console.WriteLine(newarray);

            Console.ReadLine();

        }
    }

}
