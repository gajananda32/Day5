using System;
namespace HarmonicOfNumber
{
       
    class Program
    {
    //Method for nthHarmonic
       static double nthharmonic (int N)
        {
            //variables
            float h = 1;
            for(int i = 1; i <= N; i++)
            {
                //calculation for harmonic
                h += (float)1 / i;
            }
            return h;
        }
           //static main method
        static void Main()
        {
            int N = 7;
            Console.WriteLine(nthharmonic(N));
        }
    }
}
