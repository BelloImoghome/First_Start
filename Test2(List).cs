using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Test2_List_
    {
        private static void Main(string[] args)
        {
            var numbers = new List<string>() { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty" };

            foreach (var number in numbers)
                Console.WriteLine(number);

            int choice;
            do
            {
                Console.WriteLine("Enter a number between one and twenty");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice <= 20)
                {
                    Console.WriteLine(numbers[choice]);
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            } while (choice < 21);
        }
    }
}
