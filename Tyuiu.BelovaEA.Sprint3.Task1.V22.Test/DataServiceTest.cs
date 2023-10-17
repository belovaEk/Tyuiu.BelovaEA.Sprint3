﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint3.Task1.V22.Lib;

namespace Tyuiu.BelovaEA.Sprint3.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultiplySeries()
        {
            DataService ds = new DataService();
            double a = 1;
            int start = 1;
            int stop = 2;
            Assert.AreEqual(0.186, ds.GetMultiplySeries(a, start, stop));
        }
    }
}
