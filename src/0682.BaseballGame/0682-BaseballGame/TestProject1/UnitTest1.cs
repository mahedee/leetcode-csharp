namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForTestCase1()
        {
            string[] input = new string[] { "5", "2", "C", "D", "+" };
            Assert.AreEqual(30, new Solution().CalPoints(input));
        }


        [TestMethod]
        public void TestMethodForTestCase2()
        {
            string[] input = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            Assert.AreEqual(27, new Solution().CalPoints(input));
        }


        [TestMethod]
        public void TestMethodForTestCase3()
        {
            string[] input = new string[] { "1", "C" };
            Assert.AreEqual(0, new Solution().CalPoints(input));
        }
    }
}