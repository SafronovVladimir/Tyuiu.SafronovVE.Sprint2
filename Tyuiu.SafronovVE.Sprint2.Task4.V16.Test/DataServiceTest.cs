using Tyuiu.SafronovVE.Sprint2.Task4.V16.Lib;
namespace Tyuiu.SafronovVE.Sprint2.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            var res = ds.Calculate(x, y);
            var wait = 1.25;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 2;

            var res = ds.Calculate(x, y);
            var wait = 1.75;
            Assert.AreEqual(wait, res);
        }
    }
}
