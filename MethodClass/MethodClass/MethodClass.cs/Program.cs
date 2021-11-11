using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();

            method.Operation(num1: 4, num2: 6);

            Console.Read();
        }
    }
}
