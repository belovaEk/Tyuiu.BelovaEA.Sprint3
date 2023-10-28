using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint3.Task7.V14.Lib;

namespace Tyuiu.BelovaEA.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = 0;
            int stop = 1;
            int len = 2;
            double[] array;
            array = new double[len];

            array[0] = -5.0;
            array[1] = -1.46;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(array,res);
        }
    }
}
