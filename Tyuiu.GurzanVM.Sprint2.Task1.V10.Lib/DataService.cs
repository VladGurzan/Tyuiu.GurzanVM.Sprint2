using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GurzanVM.Sprint1.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (d < c) ;
            res[1] = (a < b) & (d > c) ;
            res[2] = (a + 10 < b) || (d - 3 < c) ;
            res[3] = (a < b) && (d > c) ;
            res[4] = !(!res[0]) ;
            res[5] = (a > b) ^ (d > c) ;
            return res ;

        }
    }
}
