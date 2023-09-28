using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint1.Task6.V7.Lib;

namespace Tyuiu.SafronovVV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "ya egor mne ten";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(a);
            Assert.AreEqual(res, "y ego mn te");




        }
    }
}
