using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = new int[5] { 2 , -9 , -11 ,74 ,55};
            int n = 5;
            int result1 = oopLaba2_3.Program.Min(nums, n);
            Assert.AreEqual(-11, result1);


        }
    }
}
