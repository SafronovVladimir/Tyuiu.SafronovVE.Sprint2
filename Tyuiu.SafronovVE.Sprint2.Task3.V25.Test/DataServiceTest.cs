using Tyuiu.SafronovVE.Sprint2.Task3.V25.Lib;
namespace Tyuiu.SafronovVE.Sprint2.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;

            var res = ds.Calculate(x);

            var wait = 9.989;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;

            var res = ds.Calculate(x);

            var wait = 0.333;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;

            var res = ds.Calculate(x);

            var wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;

            var res = ds.Calculate(x);

            var wait = -3;
            Assert.AreEqual(wait, res);
        }
    }
}
