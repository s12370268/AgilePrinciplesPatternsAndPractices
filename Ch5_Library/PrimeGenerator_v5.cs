using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Library
{
    public class PrimeGenerator_v5
    {
        private static bool[] isCrossed;
        private static int[] result;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0];
            }

            InitializeArrayOfIntegers(maxValue);
            CrossOutMultiples();
            PutUncrossedIntegersIntoResult();
            return result;
        }

        private static void PutUncrossedIntegersIntoResult()
        {
            result = new int[NumberOfUncrossedIntegers()];
            for (int i = 2, j= 0; i<isCrossed.Length; i++)
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
            for (int i = 2; i < isCrossed.Length; i++)
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
            int maxPrimeFactor = CalcMaxPrimeFactor();

            for (int i = 2; i < maxPrimeFactor + 1; i++)
            {
                if (NotCrossed(i))
                {
                    CrossOutputMultiplesOf(i);
                }
            }
        }

        private static bool NotCrossed(int i)
        {
            return isCrossed[i] == false;
        }

        private static void CrossOutputMultiplesOf(int i)
        {
            for (int multiple = 2 * i; multiple < isCrossed.Length; multiple += i)
            {
                isCrossed[multiple] = true;
            }
        }

        private static int CalcMaxPrimeFactor()
        {
            // 我們劃掉質數 p 的所有倍數
            // 那麼被劃掉的所有倍數都有 p 跟 q 兩個因數
            // 如果 p 大於陣列大小的平方根，那麼 q 就不可能在大於 1 了
            // 因此 p 就是陣列中最大的質因數，也是所需反覆執行次數的上限

            double maxPrimeFactor = Math.Sqrt(isCrossed.Length) + 1;
            return (int)maxPrimeFactor;
        }

        private static void InitializeArrayOfIntegers(int maxValue)
        {
            isCrossed = new bool[maxValue + 1];

            for (int i = 2; i < isCrossed.Length; i++)
            {
                isCrossed[i] = false;
            }

        }
    }
}
