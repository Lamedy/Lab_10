using System;

namespace Lab_10
{
    internal class Program
    {
        static float del(float a, float b)
        {
            if (b == 0) { throw new Exception(); }
            else return a / b;
        }
        static void Main(string[] args)
        {
            float numb1, numb2;
            System.Console.Write("Enter digit 1\nEnter:");
            numb1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter digit 2\nEnter:");
            numb2 = Convert.ToInt32(Console.ReadLine()); ;
            try
            {
                System.Console.Write("Answer: " + del(numb1, numb2));
            }
            catch
            {
                System.Console.Write("Error: digit 2 can't be 0!\n");
            }
            System.Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }
    }
}
