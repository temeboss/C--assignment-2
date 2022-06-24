using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string ans;
            do
            {
                Console.Clear();
                Console.WriteLine("BASIC CALCULATOR");
                Console.WriteLine("---------------------------------");
                int NUM1, NUM2;
                Console.WriteLine("enter your first number");
                NUM1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your second number");
                NUM2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Diffrence");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("Choose one: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    Console.WriteLine("Addition between the numbers are: " + (NUM1 + NUM2));
                }
                else if (choose == 2)
                {
                    Console.WriteLine("Diffrence between the numbers are: " + (NUM1 - NUM2));
                }
                else if (choose == 3)
                {
                    Console.WriteLine("Multiplication between the numbers are: " + (NUM1 * NUM2));
                }
                else if (choose == 4)
                {
                    Console.WriteLine("Division between the numbers are: " + (NUM1 / NUM2));
                }
                else
                    Console.WriteLine("WRONG INPUT");

                Console.WriteLine("if you want to contiune type YES if not choose any key");
                ans = Console.ReadLine();

            } while (ans == "yes" || ans == "y");
        }
    }
}
