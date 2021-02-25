using System;

namespace MathStuff
{
    public class PrimeFactors
    {
        public static String GetPrimeFactors(int number)
        {
            string factors = "";
            

            if(isPrime(number))
            {
                return $"{number} = {number} x 1";
            }
            else
            {
                int temp = number;
                int divisor = 2;
                do
                {
                    if(temp % divisor == 0 && isPrime(divisor))
                    {
                        factors += divisor.ToString() + "|";
                        temp /= divisor; 
                        divisor = 2;
                    }

                    divisor++;

                    if(isPrime(temp))
                    {
                        factors += temp.ToString() + "|";
                    }
                    
                }while(!isPrime(temp));

                int[] primeFactorArray = GetPrimeFactorArray(factors);
                primeFactorArray = BubbleSort(primeFactorArray);
                return BuildFactorString(number, primeFactorArray);
            }
        }

        public static Boolean isPrime(int number)
        {
            Boolean prime = true;
            for(int possibleDivisor = number / 2; possibleDivisor  > 1; possibleDivisor--)
            {
                if(number % possibleDivisor == 0)
                {
                     prime = false;
                     break;
                }
            }
            return prime;
        }

        public static int[] GetPrimeFactorArray(string factors)
        {
            int numberOfFactors = 0;
            for(int i = 0; i < factors.Length; i++)
            {
                if(factors[i] == ('|'))
                {
                    numberOfFactors++;
                }
            }

            int[] primeFactors = new int[numberOfFactors];

            string temp = "";
            int arrayIndex = 0;
            for(int i = 0; i < factors.Length; i++)
            {
                if(factors[i] == '|')
                {
                    primeFactors[arrayIndex] = Int32.Parse(temp);
                    arrayIndex++;
                    temp = "";
                }
                else
                {
                    temp += factors[i];
                }
                
            }
            return primeFactors;
        }

        public static int[] BubbleSort(int[] factors)
        {
            int temp;
            for(int i = 0; i < factors.Length; i++)
            {
                for(int j = 0; j < factors.Length - 1; j++)
                {
                    if(factors[j] < factors[j+1])
                    {
                        temp = factors[j];
                        factors[j] = factors[j+1];
                        factors[j+1] = temp;
                    }
                }
            }

            return factors;
        }

        public static string BuildFactorString(int number, int[] factors)
        {
            string output = $"{number} = ";

            for(int i = 0; i < factors.Length; i++)
            {
                if(i == factors.Length - 1)
                {
                    output += factors[i].ToString();
                }
                else
                {
                    output += $"{factors[i]} X ";
                }
            }

            return output;
        }

    }
}
