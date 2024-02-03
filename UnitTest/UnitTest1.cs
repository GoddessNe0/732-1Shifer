
using _732_1Shifer;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "10";
            string output = "Простые числа до 10: 2 3 5 7 ";
            Sort sorter = new Sort();
            string result = sorter.MakeSort(input);

            Assert.AreEqual(output, result);
        }
    }
}