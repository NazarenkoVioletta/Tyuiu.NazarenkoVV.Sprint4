using Tyuiu.NazarenkoVV.Sprint4.Task0.V24.Lib;

namespace Tyuiu.NazarenkoVV.Sprint4.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            var res = ds.GetMultEvenArrEl(array);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}