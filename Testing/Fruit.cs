using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Fruit
    {
        public void arrayTests()
        {
            // Testing an array
            string[] fruits = {"apple", "kiwi", "orange", "banana", "cherry", "strawberry"};
            int arrayLength = fruits.Length;
            int shortestFruit = fruits.Min(f => f.Length);
            int longestFruit = fruits.Max(f => f.Length);

            // Use Aggregate to compare fruits to find shortest and longest word
            string shortestName = fruits.Aggregate((f1, f2) => f1.Length < f2.Length ? f1 : f2);
            string longestName = fruits.Aggregate((f1, f2) => f1.Length > f2.Length ? f1 : f2);

            // Find all the fruits that are 6 letters long
            string[] sixLetterFruits = Array.FindAll(fruits, f => f.Length == 6);
            int sixLetters = sixLetterFruits.Length;

            Console.WriteLine(string.Join(", ", fruits));
            Console.WriteLine("Fruits in array: {0}", arrayLength);
            Console.WriteLine("Length of shortest fruit in array: {0}", shortestFruit);
            Console.WriteLine("Length of longest fruit in array: {0}", longestFruit);
            Console.WriteLine("Shortest fruit is " + shortestName);
            Console.WriteLine("Longest fruit is " + longestName);
            Console.WriteLine("Number of six letter fruits = {0}.", sixLetters);
            Console.WriteLine("They are: " + string.Join(", ", sixLetterFruits));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
