using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Palindrome
    {
        public void palCheck(string checkStr)
        {
            // Convert to lower case so caps do not affect exact match for palindrome.
            string lowerCheckStr = checkStr.ToLower();

            // Create second instance of the original string to compare reversed original string to.
            string newLower = lowerCheckStr;

            // Remove spaces from string so palindrome check can be done on just the letters in the string.
            string noSpace = lowerCheckStr.Replace(" ", "");
            string newNoSpace = newLower.Replace(" ", "");

            // There is no String.Reverse method so convert the orginal string to a char array first.
            char[] arr = noSpace.ToCharArray();
            Array.Reverse(arr);

            // Change reversed char array back to a string.
            string newArr = new string(arr);

            bool isPal = false;
            if (newNoSpace == newArr)
            {
                isPal = true;
            }
            if (isPal)
            {
                Console.WriteLine("Yes, it's a palindrome!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sorry, not a palindrome.");
                Console.ReadKey();
            }
        }
    }
}
