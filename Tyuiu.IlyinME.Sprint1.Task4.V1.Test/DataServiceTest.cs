using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint1.Task4.V1.Lib;

namespace Tyuiu.IlyinME.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.028, res);
        }
    }
}
