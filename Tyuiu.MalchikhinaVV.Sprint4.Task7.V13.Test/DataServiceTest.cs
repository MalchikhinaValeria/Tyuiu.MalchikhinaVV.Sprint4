using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint4.Task7.V13.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint4.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            int[,] matrix = new int[n, m];
            string value = "159357246";
            int res = ds.Calculate(n, m, value);

            int wait = 3;

            Assert.AreEqual(wait, res);

        }
    }
}
