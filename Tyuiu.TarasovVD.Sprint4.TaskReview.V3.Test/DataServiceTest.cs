using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint4.TaskReview.V3.Lib;

namespace Tyuiu.TarasovVD.Sprint4.TaskReview.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "27182818";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
