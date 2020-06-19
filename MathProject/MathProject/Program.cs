using System;
using System.ComponentModel;

namespace MathProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var name = Console.ReadLine();
            var result = Add(2, 4);

            Console.WriteLine(result);

            var multResult = Multiply(5, 10);

            Console.WriteLine(multResult);

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
          
            return num1 * num2;

        }
    }
}



