using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint1.Task2.V15.Lib;

namespace Tyuiu.IlyinME.Sprint1.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            var res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(27, res);
        }
    }
}
