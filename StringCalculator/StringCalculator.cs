// --------------------------------------------------------------------------------------------------------------------
// <copyright company="KARL STORZ GmbH and Co. KG">
// (c) 2013 KARL STORZ GmbH and Co. KG.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace Calculators
{
    public class StringCalculator
    {
        public int Add(string s)
        {
            //check if string is empty and if true return -1 if not 0
            //return string.IsNullOrEmpty(s) ? -1 : 0;
            if(string.IsNullOrEmpty(s))
            {
                return -1;
            }
            int product = 1;
            int sum = 0;
            if (s.Contains("*"))
            {
                string[] SplitString = s.Split('*');
                for (int NumbersInArray = 0; NumbersInArray < SplitString.Length; NumbersInArray++)
                {
                    product *= int.Parse(SplitString[NumbersInArray]);
                }
                return product;
            }
            else
            {
                string[] SplitString = s.Split(',');
                for (int NumbersInArray = 0; NumbersInArray < SplitString.Length; NumbersInArray++)
                {
                    sum += int.Parse(SplitString[NumbersInArray]);
                }
                return sum;
            }
        }       
    }
}