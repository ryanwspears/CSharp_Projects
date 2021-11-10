using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment.cs
{
    class Method
    {
        public int Operation(int num1, int num2 = 2)
        {
            int result = (num1 * 5) / num2;
            return result;
        }
    }
}
