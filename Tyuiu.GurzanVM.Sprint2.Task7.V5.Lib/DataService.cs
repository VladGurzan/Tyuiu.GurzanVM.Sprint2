using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GurzanVM.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x <= -(Math.PI * 3 / 4) & y == x) && (x >= Math.PI * 4 & y == x))
            {
                return true;
            }

            else
            {
                return true;
            }

        }
    }
}
