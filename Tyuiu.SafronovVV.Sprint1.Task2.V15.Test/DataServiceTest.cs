using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint1.Task2.V15.Lib;

namespace Tyuiu.SafronovVV.Sprint1.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(4, res);
        }
    }
}
