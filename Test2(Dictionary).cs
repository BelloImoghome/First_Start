using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld

{
    public class Test2_Dictionary_
    {
        public void Test2(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "ONE");
            dict.Add(2, "TWO");
            dict.Add(3, "THREE");
            dict.Add(4, "FOUR");
            dict.Add(5, "FIVE");
            dict.Add(6, "SIX");
            dict.Add(7, "SEVEN");
            dict.Add(8, "EIGHT");
            dict.Add(9, "NINE");
            dict.Add(10, "TEN");
            dict.Add(11, "ELEVEN");
            dict.Add(12, "TWELVE");
            dict.Add(13, "THIRTEEN");
            dict.Add(14, "FOURTEEN");
            dict.Add(15, "FIFTEEN");
            dict.Add(16, "SIXTEEN");
            dict.Add(17, "SEVENTEEN");
            dict.Add(18, "EIGHTEEN");
            dict.Add(19, "NINETEEN");
            dict.Add(20, "TWENTY");

            foreach (KeyValuePair<int, string> kvp in dict)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine("Enter a number between 1 and 20");
            int input = Convert.ToInt32(Console.ReadLine());

           
        }
    }
}
