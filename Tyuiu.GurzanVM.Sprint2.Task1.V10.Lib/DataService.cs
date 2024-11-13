﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GurzanVM.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c > d);
            res[1] = (a < b) & (c >= d);
            res[2] = (a == b) || (c + 10 <= d);
            res[3] = (a <= b) && (c > d);
            res[4] = !res[2];
            res[5] = (a > b) ^ (c != d);
            return res;
        }
    }
}
