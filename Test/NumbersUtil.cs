using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class NumbersUtil
    {
        private static int[] splitBySeparator(string numbers,char separator)
        {
            return numbers.Split(separator).Select(x => string.IsNullOrWhiteSpace(x)?0:int.Parse(x)).ToArray();
        }

        public static string sortNumbers(string strNumbers, string order, char separator)
        {
            int[] numbers = splitBySeparator(strNumbers, separator);

            bubbleSort(numbers, order);

            return sortResult(numbers);
        }

        private static string sortResult(int[] numbers)
        {
            string result = "";

            foreach (int i in numbers)
                result += " "+ i;

            return result;
        }

        private static void bubbleSort(int[] numbers, string order)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                int swaps = 0;
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (order.Equals("Ascending") && greaterLower(numbers,j+1,j))
                    {
                        swaps = 1;
                    }
                    else if (order.Equals("Descending") && greaterLower(numbers, j, j+1))
                    {
                        swaps = 1;
                    }
                }
                if (swaps==0)
                    break;
            }
        }

        private static bool greaterLower(int[] numbers, int a, int b)
        {
            if (numbers[a] < numbers[b])
            {
                swapping(numbers, a, b);
                return true;
            }
            return false;
        } 
        private static void swapping(int[] numbers, int a, int b)
        {
            int temp;
            temp = numbers[a];
            numbers[a] = numbers[b];
            numbers[b] = temp;
        }
    }
}
