using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint3.Task4.V12.Lib;

namespace Tyuiu.BelovaEA.Sprint3.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int start = -1;
            int stop = 1;
            double wait = 3.043;
            Assert.AreEqual(wait, ds.Calculate(start, stop));
        }
    }
}
