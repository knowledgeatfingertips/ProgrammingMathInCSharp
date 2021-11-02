using System;

namespace Recording
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 8;
            int num2 = 4;

            Maths maths = new Maths(num1, num2);

            int add = maths.Add();
            int subtract = maths.Subtract();
            int multiply = maths.Multiply();
            int divide = maths.Divide();

            Console.WriteLine("Add => " + add.ToString());
            Console.WriteLine("Subtract => " + subtract.ToString());
            Console.WriteLine("Multiply => " + multiply.ToString());
            Console.WriteLine("Divide => " + divide.ToString());

            Console.WriteLine("All maths results.");
            Console.ReadKey();
        }
    }
}
