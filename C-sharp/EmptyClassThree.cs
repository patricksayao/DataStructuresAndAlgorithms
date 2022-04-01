using System;
using System.Linq;
using System.Collections.Generic;

namespace BigO_workspace
{
    public class EmptyClassThree
    {
        public static void FunctionOne()
        {
            string[] strings = { "a", "b", "c", "d", "e" };

            var name = new[] { "Fred", "Justin" };

            //Console.WriteLine($"{strings[2]}");
            strings = strings.Concat(new[] { "Lars" }).ToArray(); // pushes an element in an array
            //foreach (string i in strings)
            //{
            //    Console.WriteLine(i);
            //}

            Stack<string> myStack = new Stack<string>(2);
            myStack.Push("a");
            
            //adding elements using collection-initializer syntax
            var cityNames = new List<string>()
            {
                "Kiev",
                "Manila",
                "Taipei",
                "Seoul"
            };

            cityNames.ForEach(i => Console.WriteLine(i));

            List<string> stringList = new List<string>();
            stringList.Add("Patrick");

            var months = new List<string>();
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");

            //using for loop
            for (int i = 0; i < months.Count; i++)
            {
                Console.WriteLine(months[i]);
            }

            //using foreach loop
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            //using linq forEach
            months.ForEach(month => Console.WriteLine(month));

            //using linq forEach with static functi
            months.ForEach(Console.WriteLine);

            //using strings.join
            Console.WriteLine(string.Join(", ", months));
        }

    }
}
