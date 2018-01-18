using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang.MyCode.Nodes
{
    interface INode
    {
        string data { get; set; }
        string result { get; set; }
        MyNameSpace nameSpace { get; set; }

        List<INode> children { get; set; }
         
        void execute();
    }
}
