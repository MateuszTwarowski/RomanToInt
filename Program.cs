using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToInt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string x = "MCMXCVI";

            RomanToInt(x);
            
        }

        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static void RomanToInt(string romanNumber)
        {
            int intNumber = 0;
            int tempValue = int.MaxValue;

            for(int i = 0 ; i < romanNumber.Count() ; i++)
            {
                foreach (var roman in RomanMap)
                {
                    if(roman.Key == romanNumber[i])
                    {

                        if (tempValue >= roman.Value)
                        {
                            tempValue = roman.Value;
                            intNumber += tempValue;  
                        }
                        else
                        {
                            intNumber += roman.Value - (2*tempValue);
                            tempValue = int.MaxValue; 
                        }

                    }
                }
            }

            Console.WriteLine(intNumber);
            
        }
    }
}