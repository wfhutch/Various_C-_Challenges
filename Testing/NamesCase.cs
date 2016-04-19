using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class NamesCase
    {
        public void letterCase()
        {
            Console.WriteLine("Let's make a list of four names.");
            Console.WriteLine("Enter a name in any combination of letter case:");
            string[] namesArray = new string[4];
            namesArray[0] = Console.ReadLine();
            Console.WriteLine("Enter a name in any combination of letter case:");
            namesArray[1] = Console.ReadLine();
            Console.WriteLine("Enter a name in any combination of letter case:");
            namesArray[2] = Console.ReadLine();
            Console.WriteLine("Enter a name in any combination of letter case:");
            namesArray[3] = Console.ReadLine();

            Console.WriteLine("Original names:");
            foreach (string name in namesArray)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine("Converted names:");
            foreach (string name in namesArray)
            {
                string lowName = name.ToLower();
                string subName1 = lowName.Substring(0, 1).ToUpper();
                string subName2 = lowName.Substring(1, lowName.Length - 1);
                Console.WriteLine(subName1 + subName2);
            }
            Console.ReadKey();
        }
    }
}
