﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlesovskikhBA.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res += Math.Pow(1 / Math.Sin(i), 2);
            }
            return Math.Round(res, 3);
        }
    }
}