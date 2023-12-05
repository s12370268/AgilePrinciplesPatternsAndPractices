using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Library
{
    public class PrimeGenerator_v6
    {
        private static bool[] crossedOut;
        private static int[] result;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0];
            }

            UncrossIntegersUpTo(maxValue);
            CrossOutMultiples();
            PutUncrossedIntegersIntoResult();
            return result;
        }

        private static void UncrossIntegersUpTo(int maxValue)
        {
            crossedOut = new bool[maxValue + 1];
            for (int i = 2; i < crossedOut.Length; i++)
            {
                crossedOut[i] = false;
            }
        }

        private static void PutUncrossedIntegersIntoResult()
        {
            result = new int[NumberOfUncrossedIntegers()];
            for (int j = 0, i = 2; i < crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                {
                    result[j++] = i;
                }
            }
        }

        private static int NumberOfUncrossedIntegers()
        {
            int count = 0;
            for (int i = 2; i < crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                {
                    count++;
                }
            }
            return count;
        }

        private static void CrossOutMultiples()
        {
            int limit = DetermineIterationLimit();
            for (int i = 2; i <= limit; i++)
            {
                if (NotCrossed(i))
                {
                    CrossOutputMultiplesOf(i);
                }
            }
        }

        private static bool NotCrossed(int i)
        {
            return crossedOut[i] == false;
        }

        private static void CrossOutputMultiplesOf(int i)
        {
            for (int multiple = 2 * i; multiple < crossedOut.Length; multiple += i)
            {
                crossedOut[multiple] = true;
            }
        }

        private static int DetermineIterationLimit()
        {
            // 陣列中的每個倍數都有一個小於或等於陣列大小平方根的質因數
            // 因此我們不用劃掉那些這個平方根還大的數的倍數

            double iterationLimit = Math.Sqrt(crossedOut.Length);
            return (int)iterationLimit;
        }
    }
}
