namespace Ch5_Library
{
    /// <summary>
    /// 這個類別產生使用者指定之最大值範圍內的質數
    /// 使用的演算法是 Eratosthenes 篩選法
    /// 
    /// Eratosthenes，生於西元前 276 年利比亞的 Cyrene ，西元前 194 年逝世於亞歷山大
    /// 他是第一個計算地球周長的人，也因研究考慮閏年的立法和掌管亞歷山大圖書館而聞名
    /// 
    /// 這個演算法非常簡單。先給定一個整數陣列，其內容由 2 開始遞增，先劃掉 2 的倍數
    /// 然後找出一下一個尚未被劃掉的整數，去劃掉它的所有倍數。如此反覆執行到傳入之最大值得平方根為止
    /// 
    /// Written by Robert C. Martin on 9 Dec 1999 in Java
    /// Translated to C# by Micah Martin on 12 Jan 2005
    /// </summary>
    public class GeneratePrimes_v1
    {
        /// <summary>
        /// 產生一個包含質數的陣列
        /// </summary>
        /// <param name="maxValue">產生的最大值</param>
        /// <returns></returns>
        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
            {
                // 輸入不合理的值，回傳空陣列
                return new int[0];
                //throw new Exception();
            }

            // 陣列大小
            int s = maxValue + 1;
            bool[] f = new bool[s];

            // 將陣列元素初始化為 true
            for (int i = 0; i < s; i++)
            {
                f[i] = true;
            }

            // 去除已知的非質數
            f[0] = f[1] = false;

            // sieve (篩選 ; 過濾)
            for (int i = 2; i < Math.Sqrt(s) + 1; i++)
            {
                // 如果 i 未被劃掉，就劃掉其倍數
                if (f[i])
                {
                    for (int j = 2 * i; j < s; j += i)
                    {
                        // 倍數不是質數
                        f[j] = false;
                    }
                }
            }

            // 有多少質數?
            int count = 0;
            for (int i = 0; i < s; i++)
            {
                if (f[i])
                {
                    count++;
                }
            }

            int[] primes = new int[count];

            // 把質數轉移到結果陣列中
            for (int i = 0, j = 0; i < s; i++)
            {
                //若為質數
                if (f[i])
                {
                    primes[j++] = i;
                }
            }

            return primes;
        }
    }
}
