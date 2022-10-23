using System;
public class CoinFlip
{
    //variable
   public const int head = 1;
    public const int tails = 0;
    static void Main(string[] args)
    {
        //Random function to generate 0,1
        Random random = new Random();
        int coin = random.Next(2);
        //checking for coin
        if (coin == head) 
        {
            Console.WriteLine("the coin flip is Head");
        }
        else
        {
            Console.WriteLine("coin flip is is tails");
        }
    }
}
