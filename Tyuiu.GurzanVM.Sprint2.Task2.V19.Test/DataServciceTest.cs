using Tyuiu.GurzanVM.Sprint2.Task2.V19.Lib;

namespace Tyuiu.GurzanVM.Sprint2.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);


        }
    }
}