using System;
using System.Collections.Generic;
using System.Text;

namespace Recording
{
    public class Maths
    {
        private readonly int num1;
        private readonly int num2;

        public Maths(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Add() => num1 + num2;

        public int Subtract() => num1 - num2;

        public int Multiply() => num1 * num2;

        public int Divide() => num1 / num2;
    }
}
