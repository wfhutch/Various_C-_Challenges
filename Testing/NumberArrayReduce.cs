using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class NumberArrayReduce
    {
        // Check to see if number is greater than 9 digits long
        public bool lengthCheck(string input)
        {
            bool goodLength = true;
            if(input.Length > 9)
            {
                goodLength = false;
            }
            return goodLength;
        }

        // Total up all the numbers in the array
        public int arrayReducer(int num)
        {
            string numStr = num.ToString();
            char[] numChars = numStr.ToCharArray();

            int newNum = 0;
            for (var i = 0; i < numChars.Length; i++)
            {
                int numI = 0;
                int.TryParse(numChars[i].ToString(), out numI);
                newNum += numI;
            }

            Console.WriteLine("The numbers in " + num + " add up to " + newNum);

            int numReturn = 0;
            if (newNum > 9)
            {
                numReturn = arrayReducer(newNum);
            } else
            {
                numReturn = newNum; 
            }

            return numReturn;

        }
    }
}
