using System;

namespace JenkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum(2, 3).ToString());
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
