﻿using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NazarenkoVV.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item % 2 == 0 ? item : 0;
            }
            return sum;
        }
    }
}
