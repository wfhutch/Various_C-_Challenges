using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Mask
    {
        public void hideNumbers(string myString)
        {
            string sub1;

            // Assign all but last 4 chars of string to sub1
            if (myString.Length > 4)
            {
                sub1 = myString.Substring(0, myString.Length - 4);
            }
            else
            {
                sub1 = myString;
            }

            // Assign only last 4 chars of original string to sub2
            int sub1Length = sub1.Length;
            string sub2 = myString.Substring(sub1Length);

            // Strings are immutable. Convert to char array to iterate over and change
            char[] array = sub1.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (sub2.Length != 0)
                {
                    array[i] = '#';
                }

            }

            string newSub1 = new string(array);
            string newString = newSub1 + sub2;

            Console.WriteLine("Initial string: {0}", myString);
            Console.WriteLine("Hidden string: {0}", newString);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
