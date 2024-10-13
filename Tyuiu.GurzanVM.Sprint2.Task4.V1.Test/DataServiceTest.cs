using Tyuiu.GurzanVM.Sprint2.Task4.V1.Lib;

namespace Tyuiu.GurzanVM.Sprint2.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 3.5;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }

        










    }
}