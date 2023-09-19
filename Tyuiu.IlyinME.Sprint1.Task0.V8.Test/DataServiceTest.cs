﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IlyinME.Sprint1.Task0.V8.Lib;

namespace Tyuiu.IlyinME.Sprint1.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}