using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Test1B
    {
        public void Test1b(string[] args)
        {
            int option;
            do
            {

                Console.WriteLine("Your Options Are :");
                Console.WriteLine("1. Type Casting");
                Console.WriteLine("2. User Inputing");
                Console.WriteLine("3. ");


                Console.WriteLine("Enter option: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Option is: " + option);
               
                switch (option)
                {
                    case 1:
                        TypeCast typeCast = new TypeCast();
                        typeCast.TypeMethod();
                        break;

                    case 2:
                        UserInput userInput = new UserInput();
                        userInput.UserMethod();
                        break;

                    case 3:
                        Console.WriteLine("Enter either 1 or 2");
                        break;

                    default:
                        Console.WriteLine("Wrong Input. Please input number 1 or 2");
                        break;

                }
            } while (option != 4);
        }
    }
}
