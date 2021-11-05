using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class UserInput
    {
        public void UserMethod()
        {
            Console.WriteLine("Enter a Nigerian state: ");

            string state = Console.ReadLine();

            Console.WriteLine("State stated is: " + state);
        }
    }
}
