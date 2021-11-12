using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // const variable
            const string name = "Ryan";

            // var variable
            var id = 77;

            // Chain 3 constructors together
            Construct con1 = new Construct(), con2 = new Construct("Robb", 83), con3 = new Construct("Dylan");

            Console.WriteLine(con1.name + " " + con1.id);
            Console.WriteLine(con2.name + " " + con2.id);
            Console.WriteLine(con3.name + " " + con3.id);

            Console.Read();
        }
    }
}
