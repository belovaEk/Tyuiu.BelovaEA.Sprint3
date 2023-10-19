using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint3.Task3.V6.Lib;

namespace Tyuiu.BelovaEA.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplaceNumOnChar()
        {
            DataService ds = new DataService();

            char ch = 'o';
            string st = "I l7ve Pyth9n!";

            Assert.AreEqual("I love Python!", ds.ReplaceNumOnChar(st, ch));
        }
    }
}
