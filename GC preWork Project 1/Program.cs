using System;

namespace GC_preWork_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be reversed");
            int NumX = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (NumX > 0)
            {
                int remainder = NumX % 10;
                Reverse = (Reverse * 10) + remainder;
                NumX = NumX / 10;
            }
            Console.WriteLine("Reversed number is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
