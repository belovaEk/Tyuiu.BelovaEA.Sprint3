using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint3.Task0.V8.Lib;

namespace Tyuiu.BelovaEA.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double a = 2;
            int startValue = 1;
            int stopValue = 3;

            Assert.AreEqual(-37.701, ds.GetMultiplySeries(a, startValue, stopValue));
        }
    }
}
