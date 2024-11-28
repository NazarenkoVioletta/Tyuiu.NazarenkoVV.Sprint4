using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarenkoVV.Sprint4.Task2.V20.Lib;
namespace Tyuiu.NazarenkoVV.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = new int[16] { 1, 2, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1 };
            int result = ds.Calculate(array);

            Assert.AreEqual(4, result);
        }
    }
}