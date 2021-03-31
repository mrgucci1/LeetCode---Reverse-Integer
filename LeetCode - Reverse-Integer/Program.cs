using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode___Reverse_Integer
{
    class Program
    {
        //https://leetcode.com/problems/reverse-integer/
        static void Main(string[] args)
        {
            int x = 1534236469;
            int solution = reverseint(x);
            Console.WriteLine(solution);
            Console.ReadKey();
        }
        static public int reverseint(int x)
        {
            if (x > Int32.MinValue && x < Int32.MaxValue)
            {
                string output = "";
                //if negative, remove and add negative sign to output
                if (x.ToString().Contains("-"))
                {
                    x = Convert.ToInt32(x.ToString().Replace("-", ""));
                    output = "-";
                }
                //convert to char array
                char[] charArr = x.ToString().ToCharArray();
                //for loop that counts backwords, reversing int
                for (int i = charArr.Length - 1; i >= 0; i--)
                {
                    output += charArr[i];
                }
                try
                {
                    //if the new int is greater than int max, this convert will fail
                    return Convert.ToInt32(output);
                }
                //catch the overflow and return 0
                catch (OverflowException e)
                {
                    return 0;
                }
            }
            else
                return 0;
        }
    }
}
