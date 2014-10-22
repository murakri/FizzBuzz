using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "1,3,5,,15,A,23";
            foreach (string s in Input.Split(',')) {
                
                try { 
                    int Num = Convert.ToInt32(s);
                    bool flag = true;
                    if (Num % 3 == 0)
                    {
                        Console.Write("Fizz");
                        flag = false;
                    }   
                    if (Num % 5 == 0)
                    {
                        Console.Write("Buzz");
                        flag = false;
                    }
                    if (flag)
                    {
                        Console.WriteLine("Divided " + Num + " by 3");
                        Console.WriteLine("Divided " + Num + " by 5");
                    }
                    else
                        Console.WriteLine();
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid Item");
                }                
            }
        }
    }
}
