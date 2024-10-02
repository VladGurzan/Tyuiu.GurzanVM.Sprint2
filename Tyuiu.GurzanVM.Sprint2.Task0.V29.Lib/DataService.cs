﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GurzanVM.Sprint2.Task0.V29.Lib

{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 635 == y;
            res[1] = x + 630 != y;
            res[2] = x < y;
            res[3] = x + 635 > y;
            res[4] = x <= y - 700;
            res[5] = x + 600 >= y;

            return res;
        }
    }
}
