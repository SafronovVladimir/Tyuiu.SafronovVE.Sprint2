using Tyuiu.SafronovVE.Sprint2.Task7.V13.Lib;
namespace Tyuiu.SafronovVE.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;

            var res = ds.CheckDotInShadedArea(x, y);
            var wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
