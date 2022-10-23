using System;
namespace SwaptheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking input from user
            Console.WriteLine("Enter the first number a= ");
            //converting string to integer
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            //calculation
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After Swaping" +" "+ "First number a= "+a+" " + "Second number b= " + b);
        }
    }
}
