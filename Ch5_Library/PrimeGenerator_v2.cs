using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Library
{
    public class PrimeGenerator_v2
    {
        private static int s;
        private static bool[] f;
        private static int[] primes;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0];
            }

            InitializeSieve(maxValue);
            Sieve();
            LoadPrimes();
            return primes;
        }

        private static void LoadPrimes()
        {
            // 有多少個質數?
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (f[i])
                {
                    count++;
                }
            }

            primes = new int[count];

            // 把質數轉移到結果陣列中
            for (int i = 0, j = 0; i < s; i++)
            {
                if (f[i])
                {
                    primes[j++] = i;
                }
            }
        }

        private static void Sieve()
        {
            for (int i = 2; i < Math.Sqrt(s) + 1; i++)
            {
                // 如果未被劃掉，則劃掉其倍數
                if (f[i])
                {
                    for (int j = 2 * i; j < s; j += i)
                    {
                        // 倍數不是質數
                        f[j] = false;
                    }
                }
            }
        }

        private static void InitializeSieve(int maxValue)
        {
            //宣告

            // 陣列大小
            s = maxValue + 1;
            f = new bool[s];

            // 將陣列元素初始化為true
            for (int i = 0; i < s; i++)
            {
                f[i] = true;
            }

            //去除已知的非質數
            f[0] = f[1] = false;
        }
    }
}