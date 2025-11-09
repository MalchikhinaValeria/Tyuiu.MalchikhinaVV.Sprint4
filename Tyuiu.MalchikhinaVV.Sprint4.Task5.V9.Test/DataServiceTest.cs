using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint4.Task5.V9.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 1,  0,  2,  -2, -1 },
                { -4, -1,  3,  4,  0 },
                { -2,  2, 3,  -4,  1 },
                { 4, -3,  1,  1,  -1 },
                { 3,  -3, -1,  2, -4 }
            };

            int wait = 12;
            int result = ds.Calculate(matrix);

            Assert.AreEqual(wait, result);
        }
    }
}
