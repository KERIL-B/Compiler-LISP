using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang.MyCode
{
    class Variable
    {
        public string name { get; set; }
        public string value { get; set; }

        public Variable(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
