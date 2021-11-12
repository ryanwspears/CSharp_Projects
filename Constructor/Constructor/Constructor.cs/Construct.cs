using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.cs
{
    public class Construct
    {
        public string name;
        public int id;

        public Construct() : this("Ryan", 77)
        {
            
        }
        public Construct(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public Construct(string name) : this(name, 93)
        {

        }
    }
}
