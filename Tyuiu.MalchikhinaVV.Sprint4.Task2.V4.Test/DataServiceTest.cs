using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint4.Task2.V4.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint4.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 9, 8, 5, 3, 7, 8, 4, 5, 2, 6, 3, 7 };
            int res = ds.Calculate(array);
            int wait = 39;

            Assert.AreEqual(wait, res);
        }
    }
}
