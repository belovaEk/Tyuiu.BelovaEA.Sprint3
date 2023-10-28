using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovaEA.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        if (i < 7)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
