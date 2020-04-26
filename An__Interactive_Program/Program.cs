using System;

namespace An__Interactive_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            while (true)
            {
                Console.WriteLine("Enter an value: ");
                value = Convert.ToInt32(Console.ReadLine());

                if (value < 10)
                {
                    Console.WriteLine("Your number is to small: " + value);
                }
                else
                {
                    Console.WriteLine("Your number is greater then 10: " +value);
                }

            }

        }
    }
}
