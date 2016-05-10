using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class BiggestNumber
    {
        public int a;
        public int b;
        public int c;

        public BiggestNumber(string num1, string num2, string num3)
        {
            //Convert strings to numbers
            a = int.Parse(num1);
            b = int.Parse(num2);
            c = int.Parse(num3);
        }
    }

    class BigNum
    {

        string num1;
        string num2;
        string num3;
        string checkNum1;
        string checkNum2;
        string checkNum3;
        bool valid1 = false;
        bool valid2 = false;
        bool valid3 = false;

        public void findBiggest()
        {
            Console.WriteLine("Enter a number: ");
            num1 = Console.ReadLine();
            validate1(num1);

            while (!valid1)
            {
                validate1(checkNum1);
            }

            Console.WriteLine("Good! Now enter a second number!");
            num2 = Console.ReadLine();
            validate2(num2);

            while (!valid2)
            {
                validate2(checkNum2);
            }

            Console.WriteLine("Great! Now enter one more number!");
            num3 = Console.ReadLine();
            validate3(num3);

            while (!valid3)
            {
                validate3(checkNum3);
            }

            //Assign each value entered by user to ints a, b, and c
            BiggestNumber biggie = new BiggestNumber(num1, num2, num3);
            Console.WriteLine("Number one is {0}", biggie.a);
            Console.WriteLine("Number two is {0}", biggie.b);
            Console.WriteLine("Number three is {0}", biggie.c);


            //Create new variables to assign biggie values to.  This just helps clean up code in comparisons by not typing 
            //biggie every time.
            int a = biggie.a;
            int b = biggie.b;
            int c = biggie.c;

            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", c);
            }

            Console.ReadKey();

        }

        private void validate1(string num)
        {
            var useable1 = Regex.Match(num, "^[0-9]{1,9}$");
            if (useable1.Success)
            {
                valid1 = true;
                num1 = num;
            }
            else
            {
                Console.WriteLine("Please enter a whole number less than 10 digits long with no letters!");
                checkNum1 = Console.ReadLine();
            }
        }

        private void validate2(string num)
        {
            var useable2 = Regex.Match(num, "^[0-9]{1,9}$");
            if (useable2.Success)
            {
                valid2 = true;
                num2 = num;
            }
            else
            {
                Console.WriteLine("Please enter a whole number less than 10 digits long with no letters!");
                checkNum2 = Console.ReadLine();
            }
        }

        private void validate3(string num)
        {
            var useable3 = Regex.Match(num, "^[0-9]{1,9}$");
            if (useable3.Success)
            {
                valid3 = true;
                num3 = num;
            }
            else
            {
                Console.WriteLine("Please enter a whole number less than 10 digits long with no letters!");
                checkNum3 = Console.ReadLine();
            }
        }
    }
}

