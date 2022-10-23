using System;
namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting with for loop
            for(int i = 0; i <= 10; i++)
            {
                //checking for even r odd
                if (i % 2 == 0)
                {
                    Console.WriteLine(i +" "+ "is even");
                }
                else
                {
                    Console.WriteLine(i +" "+ "is odd");
                }
            }
        }
    }
}
