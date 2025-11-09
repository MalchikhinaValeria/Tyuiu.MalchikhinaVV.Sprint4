using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MalchikhinaVV.Sprint4.Task6.V19.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint4.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new();

            string[] array = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };

            int res = ds.Calculate(array);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
