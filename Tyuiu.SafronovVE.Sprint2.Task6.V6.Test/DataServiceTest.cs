using Tyuiu.SafronovVE.Sprint2.Task6.V6.Lib;
namespace Tyuiu.SafronovVE.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int value1, value2;
            value1 = 1;
            value2 = 12;

            var res = ds.FindCardNameAndValue(value1, value2);
            var wait = "Дама пик";
            Assert.AreEqual(wait, res);
        }
    }
}
