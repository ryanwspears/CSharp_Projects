using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload.cs
{
    class Method
    {
        public int Operate(int num)
        {
            int result = num * 5;
            return result;
        }
        public int Operate(decimal num)
        {
            int result = Convert.ToInt32(num) + 15;
            return result;
        }
        public int Operate(string num)
        {
            int result = Convert.ToInt32(num) * (5 + 5);
            return result;
        }
    }
}
