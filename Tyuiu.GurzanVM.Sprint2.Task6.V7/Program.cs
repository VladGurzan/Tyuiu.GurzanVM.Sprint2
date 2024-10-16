using Tyuiu.GurzanVM.Sprint2.Task6.V7.Lib;

namespace Tyuiu.GurzanVM.Sprint2.Task6.V7
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();








            Console.Title = "Спринт #2 | Выполнил: Гурзан.В.М  | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число от 1 до 365:");
            int startYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число от 1 до 12:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                string day = ds.FindMonthName(startYear, n);
                Console.WriteLine(day);
            }
            catch
            {
                Console.WriteLine("Неверно");
            }
            Console.ReadKey();

            int res;
        }
    }
}