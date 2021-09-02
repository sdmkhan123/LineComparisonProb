using System;

namespace LineComparisonProb
{
    class Program
    {
        static double lengthOfLine()
        {
            int x11 = Convert.ToInt32(Console.ReadLine());
            int x12 = Convert.ToInt32(Console.ReadLine());
            int y11 = Convert.ToInt32(Console.ReadLine());
            int y12 = Convert.ToInt32(Console.ReadLine());
            return Math.Sqrt(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2) * 1.0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            double lengthOfLineFirst = lengthOfLine();
            double lengthOfLineSecond = lengthOfLine();
            if (lengthOfLineFirst == lengthOfLineSecond)
            {
                Console.WriteLine("Both lines have equal length");
            }
            else
            {
                Console.WriteLine("Both lines are not equal length");
            }
        }
    }
}
