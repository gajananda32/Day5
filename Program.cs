using System;
namespace TocheckFactors
{
    class program
    {
        static void Main(string[] args)
        {
            //taking input from user
            Console.WriteLine("Enter the number: ");
           //converting string to integer 
           int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                //checking for factors
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
