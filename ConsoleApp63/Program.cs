using System;
//task 3
namespace ConsoleApp63
{
internal class Program
    {
        static int num()
        {
            Random random = new Random();
            return random.Next(0,10);
        }
        delegate int MyDelegate();
        delegate int MyDelegate2(MyDelegate[] arr);
        float exe(MyDelegate[] arr)
        {
           return (arr[0].Invoke() + arr[1].Invoke() + arr[2].Invoke())/3;
        }
        static void Main(string[] args)
        {
            MyDelegate[] mydelegate = { new MyDelegate(num), new MyDelegate(num), new MyDelegate(num) };
            MyDelegate2 executed = (MyDelegate[] arr) => (arr[0].Invoke() + arr[1].Invoke() + arr[2].Invoke()) / 3;
            Console.WriteLine(executed(mydelegate));
        }
    }
}
