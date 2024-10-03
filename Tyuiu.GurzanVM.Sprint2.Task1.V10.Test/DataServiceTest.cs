using Tyuiu.GurzanVM.Sprint1.Task1.V10.Lib;

namespace Tyuiu.GurzanVM.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 455 ;
            int b = 335 ;
            int c = 14 ;
            int d = 17 ;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}