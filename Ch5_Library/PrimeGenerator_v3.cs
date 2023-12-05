using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Library
{
    public class PrimeGenerator_v3
    {
        private static bool[] f;
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
            // 有多少個質數?
            int count = 0;
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i])
                {
                    count++;
                }
            }

            result = new int[count];

            // 把質數轉移到結果陣列中
            for (int i = 0, j = 0; i < f.Length; i++)
            {
                if (f[i])
                {
                    result[j++] = i;
                }
            }
        }

        private static void CrossOutMultiples()
        {
            for (int i = 2; i < Math.Sqrt(f.Length) + 1; i++)
            {
                // 如果未被劃掉，則劃掉其倍數
                if (f[i])
                {
                    for (int j = 2 * i; j < f.Length; j += i)
                    {
                        // 倍數不是質數
                        f[j] = false;
                    }
                }
            }
        }

        private static void InitializeArrayOfIntegers(int maxValue)
        {
            //宣告

            f = new bool[maxValue + 1];

            //非質數，也非倍數
            f[0] = f[1] = false;

            // 將陣列元素初始化為true
            for (int i = 2; i < f.Length; i++)
            {
                f[i] = true;
            }

        }
    }
}
