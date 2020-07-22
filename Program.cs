using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbersXOR
{
    class Program
    {
        private static string SwapNumbers(int n1, int n2)
        {
            n1 = n1 ^ n2;
            n2 = n1 ^ n2;
            n1 = n1 ^ n2;
            string data = "The swapped numbers are: " + n1 + " and " + n2;
            return data;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first disgit: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second digit. ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var resultant = Program.SwapNumbers(num1, num2);
            Console.WriteLine(resultant);
            Console.ReadLine();
        }
    }
}
