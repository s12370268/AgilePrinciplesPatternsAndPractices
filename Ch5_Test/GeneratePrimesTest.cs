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
    }
}