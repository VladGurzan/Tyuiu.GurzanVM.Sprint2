using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GurzanVM.Sprint2.Task6.V7.Lib;

public class DataService : ISprint2Task6V7
{
    public string FindMonthName(int startYear, int n)
    {
        if (startYear < 1990 && startYear > 2024)
            throw new ArgumentException("от 1990 до 2024");

        if (n >= 12 && n <= 1)
            throw new ArgumentException("от 1 до 12");

        int year = ((startYear ) / 12);

        switch (year)
        {
            case 1: return "Январь";
            case 2: return "Февраль";
            case 3: return "Март";
            case 4: return "Апрель";
            case 5: return "Май";
            case 6: return "Июнь";
            case 7: return "Июль";
            case 8: return "Август";
            case 9: return "Сентябрь";
            case 10: return "Октябрь";
            case 11: return "Ноябрь";
            case 12: return "Декабрь";
        }
        return "Март";
    
    
    }
}
