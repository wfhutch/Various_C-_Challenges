using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Replace all but the last four characters of a string with #
            Console.WriteLine("Enter a number of any length:");
            string myString = Console.ReadLine();
            Mask mask = new Mask();
            mask.hideNumbers(myString);

            // Testing an array of fruit
            Fruit fruit = new Fruit();
            fruit.arrayTests();

            // Check to see if a string is a palindrome
            Console.WriteLine("Enter some text to check for palindrome:");
            string checkStr = Console.ReadLine();
            Palindrome pal = new Palindrome();
            pal.palCheck(checkStr);

            //Add array of numbers until only a single number is left. Ex: 987 added together = 24 which added together = 6.
            NumberArrayReduce arr = new NumberArrayReduce();
            Console.WriteLine("Enter a number up to nine digits long:");
            string userInput = Console.ReadLine();
            bool goodLength = arr.lengthCheck(userInput);
            while (goodLength == false)
            {
                Console.WriteLine("Oops, too big!  Try again with a number that is " + Environment.NewLine
                    + "9 digits long or less.");
                userInput = Console.ReadLine();
                goodLength = arr.lengthCheck(userInput);
            }
            // Convert number string that user entered into an int and pass that value into the arrayReducer method.
            int answer = 0;
            int.TryParse(userInput.ToString(), out answer);
            int returnVal = arr.arrayReducer(answer);

            Console.WriteLine("So " + answer + " reduces to: " + returnVal);
            Console.ReadKey();

            // Change string array so that each name has uppercase first letter and the rest are lowercase.
            NamesCase names = new NamesCase();
            names.letterCase();
        }
    }
}
