using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoskesDoubleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Double(userNumber));
        }
        static int Double(int userNumber)
        {
            return userNumber + userNumber;
        }

    }
}
