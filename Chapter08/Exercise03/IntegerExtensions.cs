using System;
using System.Collections.Generic;
using System.Numerics;

namespace Exercise03
{
    


    public static class IntegerExtensions
    {
        // BUILD DICTIONARIES FOR NUMBER NOMENCLATURE
        private static readonly Dictionary<string, string> tens = new Dictionary<string, string>
        {
            {"2", "twenty"},
            {"3", "thirty"},
            {"4", "forty"},
            {"5", "fifty"},
            {"6", "sixty"},
            {"7", "seventy"},
            {"8", "eighty"},
            {"9", "ninety"},
            {"10", "ten"},
            {"11", "eleven"},
            {"12", "twelve"},
            {"13", "thirteen"},
            {"14", "fourteen"},
            {"15", "fifteen"},
            {"16", "sixteen"},
            {"17", "seventeen"},
            {"18", "eighteen"},
            {"19", "nineteen"}
        };

        private static readonly Dictionary<string, string> ones = new Dictionary<string, string>
        {
            {"1", "one"},
            {"2", "two"},
            {"3", "three"},
            {"4", "four"},
            {"5", "five"},
            {"6", "six"},
            {"7", "seven"},
            {"8", "eight"},
            {"9", "nine"}
        };
        private static readonly Dictionary<string, string> bigNumberNames = new Dictionary<string, string>
        {
            {"0", ""},
            {"3", "thousand"},
            {"6", "million"},
            {"9", "billion"},
            {"12", "trillion"},
            {"15", "quadrillion"},
            {"18", "quintillion"},
            {"21", "sextillion"},
            {"24", "septillion"}
        };
 
        public static string Towards(this Int64 input)
        {
            string stringInput = input.ToString();

            int power = stringInput.Length - 1;
            int powerDivisor = ((int) power/3) * 3; // used for big number exponent
            int firstSubNumberLength = stringInput.Length % 3;
            
            string numberInWords = "";
            string subNumber;
            string subNumberInWords;

            for(int i = 0; powerDivisor >= 0; powerDivisor -= 3)
            {
                if(powerDivisor == 0)
                {
                    subNumber = stringInput.Substring(i, 3);
                    subNumberInWords = getSubNumberInWords(subNumber);
                    if(subNumber[0] == '0') numberInWords += "and " + subNumberInWords;
                    else numberInWords += subNumberInWords;
                    i += 3; 
                }
                else if(i == 0)
                {
                    subNumber = stringInput.Substring(i, firstSubNumberLength);   
                    subNumberInWords = getSubNumberInWords(subNumber);
                    if(!subNumberInWords.Equals("")) numberInWords += subNumberInWords + " " + bigNumberNames[powerDivisor.ToString()] + ", ";
                    i += firstSubNumberLength;
                }
                else
                {
                    subNumber = stringInput.Substring(i, 3);
                    subNumberInWords = getSubNumberInWords(subNumber);
                    if(!subNumberInWords.Equals("")) numberInWords += subNumberInWords + " " + bigNumberNames[powerDivisor.ToString()] + ", ";
                    i += 3;
                }
                
            }

            return numberInWords;
        }

        public static string Towards(this BigInteger input)
        {
            string stringInput = input.ToString();

            int power = stringInput.Length - 1;
            int powerDivisor = ((int) power/3) * 3; // used for big number exponent
            int firstSubNumberLength = stringInput.Length % 3;
            
            string numberInWords = "";
            string subNumber;
            string subNumberInWords;

            for(int i = 0; powerDivisor >= 0; powerDivisor -= 3)
            {
                if(powerDivisor == 0)
                {
                    subNumber = stringInput.Substring(i, 3);
                    subNumberInWords = getSubNumberInWords(subNumber);
                    if(subNumber[0] == '0') numberInWords += "and " + subNumberInWords;
                    else numberInWords += subNumberInWords;
                    i += 3; 
                }
                else if(i == 0)
                {
                    subNumber = stringInput.Substring(i, firstSubNumberLength);   
                    subNumberInWords = getSubNumberInWords(subNumber);
                    if(!subNumberInWords.Equals("")) numberInWords += subNumberInWords + " " + bigNumberNames[powerDivisor.ToString()] + ", ";
                    i += firstSubNumberLength;
                }
                else
                {
                    subNumber = stringInput.Substring(i, 3);
                    subNumberInWords = getSubNumberInWords(subNumber);
                    if(!subNumberInWords.Equals("")) numberInWords += subNumberInWords + " " + bigNumberNames[powerDivisor.ToString()] + ", ";
                    i += 3;
                }
                
            }

            return numberInWords;
        }

        private static string getSubNumberInWords(string subNumber)
        {
            string subNumberInWords = "";
            bool useAnd = false;
            for(int i = 0; i < subNumber.Length; i++)
            {
                switch(3-subNumber.Length + i)
                {
                    case 0:
                        if(subNumber[i] == '0') continue;
                        subNumberInWords += ones[subNumber[i].ToString()] + " hundred";
                        useAnd = true;
                        break;
                    case 1:
                        if(subNumber.Length == 3 && subNumber[i] == '0' && subNumber[i-1] != '0')
                        {
                            useAnd = true;
                            continue;
                        }
                        if(subNumber[i] == '0')
                        {
                            continue;
                        } 
                        if(Int64.Parse(subNumber[i..^0]) >= 10 && Int64.Parse(subNumber[i..^0]) <= 19)
                        {
                            if(useAnd) subNumberInWords += " and " + tens[subNumber[i..^0]];
                            else subNumberInWords += tens[subNumber[i..^0]];
                            i = 3;
                        }
                        else
                        {
                            if(useAnd)
                            {
                                subNumberInWords += " and " + tens[subNumber[i].ToString()];
                                useAnd = false;
                            } 
                            else if(subNumber.Length == 3 && subNumber[i-1] != '0')
                            {
                                subNumberInWords += " " + tens[subNumber[i].ToString()];
                            }
                            else
                            {
                                subNumberInWords += tens[subNumber[i].ToString()];  
                            }                           
                        }
                        break;
                    case 2: 
                        if(subNumber[i].ToString().Equals("0")) continue; 
                        if(useAnd)
                        {
                            subNumberInWords += " and " + ones[subNumber[i].ToString()];
                        }
                        else if(subNumber.Length == 3 && subNumber[i-1] != '0')
                        {
                            subNumberInWords += " " + ones[subNumber[i].ToString()];
                        }
                        else
                        {
                            subNumberInWords += ones[subNumber[i].ToString()];
                        }
                        break;
                }
            }
            return subNumberInWords;
        }
    }
}