using System;

namespace firstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adition program");
            Console.Write("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int addition = num1 + num2;
            int subtraction = num1 - num2;

            Console.Write(" Addition is : " + addition);
            Console.Write("\n Subtraction is : " + subtraction+ "\n");
        }
    }
}
