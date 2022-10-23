using System;
namespace PowerOftwo
{
    class Program
    {
        //variable
        public const double  N = 10;
        static void Main(string[] args)
        {
            for (double  i = 1; i <= N; i++)
            {
                //Using inbuilt power function
                double  table = Math.Pow(i,i);
                Console.WriteLine(table);
            }
        }
    }
}
