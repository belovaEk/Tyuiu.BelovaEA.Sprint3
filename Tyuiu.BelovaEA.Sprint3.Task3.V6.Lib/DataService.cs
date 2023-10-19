using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovaEA.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char ch in value)
            {
                if (Char.IsDigit(ch))
                {
                    value = value.Replace(ch, item);
                }
            }
            return value;
        }
    }
}
