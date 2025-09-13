﻿using Tyuiu.SafronovVE.Sprint2.Task0.V4.Lib;
namespace Tyuiu.SafronovVE.Sprint2.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 332;
            int y = 324;
            bool[] res = new bool[6];
            res = ds.GetCompareOperation(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
