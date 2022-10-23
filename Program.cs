using System;
    namespace TocheckVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking charcter from user
            Console.WriteLine("Enter any charcter ch: ");
            //converting string to char
            char ch = Convert.ToChar(Console.ReadLine());
            //checking for vowel using OR operator
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + " " + "is Vowel");
            }
            else
            {
                Console.WriteLine(ch + " " + "is Consonet");
            }
        }
    }
}
