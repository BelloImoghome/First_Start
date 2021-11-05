using System;

namespace HelloWorld
{
    class Car
    {
        public string model;

        public Car()
        {
            model = "Mustang";
        }

        public void ProjectMethod()
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }
    }
}
