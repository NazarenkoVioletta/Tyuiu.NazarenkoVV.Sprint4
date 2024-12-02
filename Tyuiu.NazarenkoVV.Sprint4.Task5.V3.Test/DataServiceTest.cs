using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarenkoVV.Sprint4.Task5.V3.Lib;

namespace Tyuiu.NazarenkoVV.Sprint4.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -5, 2, 1, -4, 3},
                                          { -2, 4, -3, 1, 3},
                                          { 2, 4, -3, -2, 1 },
                                          { -1, -4, 2, -5, 3},
                                          {  4, 4, -2, 1, 3} };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5,5] { {0, 2, 1, 0, 3}, 
                                         {0, 4, 0, 1, 3},
                                         {2, 4, 0, 0, 1},
                                         {0, 0, 2, 0, 3},
                                         {4, 4, 0, 1, 3} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}