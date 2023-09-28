using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint1.Task6.V4.Lib;

namespace Tyuiu.IlyinME.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strT = "Привет юный друг. Здесь деревянное, оловянное и стеклянное окно";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strT);
            Assert.AreEqual("деревянное, оловянное, стеклянное", res);
        }
    }
}
