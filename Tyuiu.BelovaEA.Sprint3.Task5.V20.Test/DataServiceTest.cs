using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint3.Task5.V20.Lib;

namespace Tyuiu.BelovaEA.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 1;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 2;
            double wait = 7.802;
            Assert.AreEqual(wait, ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
        }
    }
}
