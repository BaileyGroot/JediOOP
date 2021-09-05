using System;
using System.Collections.Generic;

namespace JediOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Dictionary<string, int> Task = new Dictionary<string, int>();

            // Adding name and age to the dictionary.
            Task.Add("Bailey", 20);

            // Adding a new name to the value.
            Task["Han"] = new int();

            // It removes the "key" from the dictionary but if it couldn't find the key it will return with invalid response.

            if (Task.Remove("Han"))
            {
                Console.WriteLine("Removed from the dictionary");
            }
            else
            {
                Console.WriteLine("Couldn't locate the key.");
            }

            // How to add "age" to a value when it 

            foreach (var emp in Task)
            {
                Console.WriteLine(emp.Key);
            }


        }
    }
}
 