using Ch5_Library;

namespace Ch5_Test
{
    [TestClass]
    public class GeneratePrimesTest
    {
        [TestMethod]
        public void TestGeneratePrimes_v1()
        {
            int[] nullArray = GeneratePrimes_v1.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);

            int[] minArray = GeneratePrimes_v1.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);

            int[] threeArray = GeneratePrimes_v1.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);

            int[] centArray = GeneratePrimes_v1.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }

        [TestMethod]
        public void TestPrimeGenerator_v2()
        {
            int[] nullArray = PrimeGenerator_v2.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);

            int[] minArray = PrimeGenerator_v2.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);

            int[] threeArray = PrimeGenerator_v2.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);

            int[] centArray = PrimeGenerator_v2.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }

        [TestMethod]
        public void TestPrimeGenerator_v3()
        {
            int[] nullArray = PrimeGenerator_v3.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);

            int[] minArray = PrimeGenerator_v3.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);

            int[] threeArray = PrimeGenerator_v3.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);

            int[] centArray = PrimeGenerator_v3.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }

        [TestMethod]
        public void TestPrimeGenerator_v4()
        {
            int[] nullArray = PrimeGenerator_v4.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);

            int[] minArray = PrimeGenerator_v4.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);

            int[] threeArray = PrimeGenerator_v4.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);

            int[] centArray = PrimeGenerator_v4.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }

        [TestMethod]
        public void TestPrimeGenerator_v5()
        {
            int[] nullArray = PrimeGenerator_v5.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);

            int[] minArray = PrimeGenerator_v5.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);

            int[] threeArray = PrimeGenerator_v5.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);

            int[] centArray = PrimeGenerator_v5.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }

        [TestMethod]
        public void TestPrimeGenerator_v6()
        {
            int[] nullArray = PrimeGenerator_v6.GeneratePrimeNumbers(0);
            Assert.AreEqual(nullArray.Length, 0);

            int[] minArray = PrimeGenerator_v6.GeneratePrimeNumbers(2);
            Assert.AreEqual(minArray.Length, 1);
            Assert.AreEqual(minArray[0], 2);

            int[] threeArray = PrimeGenerator_v6.GeneratePrimeNumbers(3);
            Assert.AreEqual(threeArray.Length, 2);
            Assert.AreEqual(threeArray[0], 2);
            Assert.AreEqual(threeArray[1], 3);

            int[] centArray = PrimeGenerator_v6.GeneratePrimeNumbers(100);
            Assert.AreEqual(centArray.Length, 25);
            Assert.AreEqual(centArray[24], 97);
        }

        [TestMethod]
        public void TestExhaustive()
        {
            for (int i = 2; i < 500; i++)
            {
                VerifyPrimeList(PrimeGenerator_v6.GeneratePrimeNumbers(i));
            }
        }

        private void VerifyPrimeList(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                VerifyPrime(list[i]);
            }
        }

        private void VerifyPrime(int n)
        {
            for (int factor = 2; factor < n; factor++)
            {
                Assert.IsTrue(n % factor != 0);
            }
        }
    }
}