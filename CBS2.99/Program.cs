using System;
//task 2
namespace CBS2._99
{
    internal class Program
    {
        public delegate void MyDelegate(double x, double y);
        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            Console.WriteLine("enter your operand 1:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your operand 2:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the operation:\n +\t -\t *\t /");
            switch (Console.ReadLine()){ 
                case "+":
                    {
                        myDelegate = (x, y) => Console.WriteLine(x + y);
                        myDelegate(x, y);
                        break;
                    }
                case "-":
                    {
                        myDelegate = (x, y) => Console.WriteLine(x - y);
                        myDelegate(x, y);
                        break;
                    }
                case "*":
                    {
                        myDelegate = (x, y) => Console.WriteLine(x * y);
                        myDelegate(x, y);
                        break;
                    }
                case "/":
                    {
                        if (y == 0) {
                            Console.WriteLine("div on 0 exeption (y = 0)");
                            break;
                        }
                        myDelegate = (x, y) => Console.WriteLine(x + y);
                        myDelegate(x, y);
                        break;
                    }
            }
        }
    }
}
