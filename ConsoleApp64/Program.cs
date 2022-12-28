using System;
//task 5
namespace ConsoleApp64
{
    internal class Program
    {
        delegate float MyDel(int x, int y, int z);
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 variables");
            MyDel del = (int x, int y, int z) =>
            {
                Console.WriteLine("res:" + (x + z + y) / 3);
                return (x + z + y) / 3;
            };
            del(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
        }
    }
}
