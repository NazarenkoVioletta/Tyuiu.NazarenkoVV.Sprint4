using Tyuiu.NazarenkoVV.Sprint4.Task1.V13.Lib;

namespace Tyuiu.NazarenkoVV.Sprint4.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] nums = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            int res = ds.Calculate(nums), wait = 22;
            Assert.AreEqual(wait, res);
        }
    }
}