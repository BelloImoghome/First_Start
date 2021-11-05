using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Test1
    {
        public void Test(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Username is: " + username);

            int rollover = 100;
            do
            {

                Console.WriteLine("Your Options Are :");
                Console.WriteLine("1. Type Casting");
                Console.WriteLine("2. User Inputing");
                Console.WriteLine("3. End Program");


                Console.WriteLine("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Option is: " + option);

                if (option == 1)
                {
                    TypeCast typeCast = new TypeCast();
                    typeCast.TypeMethod();
                }
                else if (option == 2)
                {
                    UserInput userInput = new UserInput();
                    userInput.UserMethod();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Thank You and Good-Bye");
                    break;
                }
                else
                {
                    Console.WriteLine("Press 3 to Exit");
                }

            }
            while (rollover > 0);
        }
    }

}
