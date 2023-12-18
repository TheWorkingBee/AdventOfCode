using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023._1
{
    internal class Digits
    {
        public string[] input;
        public List<int> digits = new List<int>();
        public Digits()
        {
            input = File.ReadAllLines("C:\\Users\\yatt\\source\\repos\\AdventOfCode\\2023\\2023\\1\\input.txt");
        }

        public static char FindDig(char[] val)
        {
            foreach (char e in val)
            {
                if (char.IsDigit(e)){
                    return e;
                }
            }

            throw new Exception("No Digit");
        }

        public static string FindDigits(string val)
        {
            char[] v = val.ToCharArray();
            char[] vr = (char[])v.Reverse().ToArray();

            return $"{FindDig(v)}{FindDig(vr)}";

        }

        public void getDigits()
        {
            int[] ds = { };
            foreach (string s in input)
            {
                int digs = int.Parse( FindDigits(s));
                digits.Add(digs);
            }
        }


    }
}
