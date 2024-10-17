using Tyuiu.GurzanVM.Sprint2.Task7.V5.Lib;

namespace Tyuiu.GurzanVM.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                DataService ds = new DataService();

                Console.WriteLine("Введите значение X:");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение Y:");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(ds.CheckDotInShadedArea(x, y));

                Console.ReadKey();
            }
        }
    }
}
