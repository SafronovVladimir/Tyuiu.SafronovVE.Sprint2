using Tyuiu.SafronovVE.Sprint2.Task5.V7.Lib;
namespace Tyuiu.SafronovVE.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMounthName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Январь", ds.FindMonthName(1, 0));
            Assert.AreEqual("Февраль", ds.FindMonthName(1, 1));
            Assert.AreEqual("Март", ds.FindMonthName(1, 2));
            Assert.AreEqual("Апрель", ds.FindMonthName(1, 3));
            Assert.AreEqual("Май", ds.FindMonthName(1, 4));
            Assert.AreEqual("Июнь", ds.FindMonthName(1, 5));
            Assert.AreEqual("Июль", ds.FindMonthName(1, 6));
            Assert.AreEqual("Август", ds.FindMonthName(1, 7));
            Assert.AreEqual("Сентябрь", ds.FindMonthName(1, 8));
            Assert.AreEqual("Октябрь", ds.FindMonthName(1, 9));
            Assert.AreEqual("Ноябрь", ds.FindMonthName(1, 10));
            Assert.AreEqual("Декабрь", ds.FindMonthName(1, 11));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(1, 12);
            });
        }
    }
}
