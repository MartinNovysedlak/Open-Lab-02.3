using System;

namespace Open_Lab_02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a % b;
            Console.WriteLine(c);
        }
    }
}
