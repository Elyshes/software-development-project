// --------------------------------------------------------------------------------------------------------------------
// <copyright company="KARL STORZ GmbH and Co. KG">
// (c) 2013 KARL STORZ GmbH and Co. KG.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace Calculators
{
    public class StringCalculator
    {
        public int calculate(string s, IOperation operation)
        {
            //check if string is empty and if true return -1 if not 0
            //return string.IsNullOrEmpty(s) ? -1 : 0;
            if(string.IsNullOrEmpty(s))
            {
                return -1;
            }
            /*
            if (s.Contains("*"))
            {
                int product = 1;

                string[] SplitString = s.Split('*');
                for (int NumbersInArray = 0; NumbersInArray < SplitString.Length; NumbersInArray++)
                {
                    product *= int.Parse(SplitString[NumbersInArray]);
                }
                return product;
            }
            else
            {
                int sum = 0;
                string[] SplitString = s.Split(',');
                for (int NumbersInArray = 0; NumbersInArray < SplitString.Length; NumbersInArray++)
                {
                    sum += int.Parse(SplitString[NumbersInArray]);
                }
                return sum;
            }*/
            List<int> ConvertedNumbers = ConvertStringNumbersToIntNumbers(s);
            return operation.Calcuate(ConvertedNumbers);
        }

        private List<int> ConvertStringNumbersToIntNumbers(string s)
        {
            List<int> ConvertedNumbers = new List<int>();
            string[] SplitString = s.Split(',');
            for(int i = 0; i < SplitString.Length; i++)
            {
                ConvertedNumbers.Add(int.Parse(SplitString[i]));
            }
            return ConvertedNumbers;
        }
    }
}