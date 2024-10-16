using Tyuiu.GurzanVM.Sprint2.Task6.V7.Lib;
using System.Net.Http.Headers;

namespace Tyuiu.GurzanVM.Sprint2.Task6.V7.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestFindMonthName()
    {
        DataService ds = new DataService();

        Assert.AreEqual("Некоректный день", ds.FindMonthName(2, 11));

        Assert.ThrowsException<ArgumentException>(() =>
        {
            ds.FindMonthName(-1, 366);
        });

        Assert.ThrowsException<ArgumentException>(() =>
        {
            ds.FindMonthName(-1, 13);
        });
    }
}