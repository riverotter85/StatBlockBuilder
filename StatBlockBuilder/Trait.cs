using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatBlockBuilder
{
    public class Trait
    {
        private string name;

        public Trait()
        {
        }

        public Trait(string name)
        {
            this.name = name;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
