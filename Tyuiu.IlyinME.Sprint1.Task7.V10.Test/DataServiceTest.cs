using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint1.Task7.V10.Lib;

namespace Tyuiu.IlyinME.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 1;
            DataService ds = new DataService();
            var res = ds.Calculate(x);
            Assert.AreEqual(-13.142, res);
        }
    }
}
