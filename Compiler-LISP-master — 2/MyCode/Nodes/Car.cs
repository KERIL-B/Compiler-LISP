using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;

namespace MathLang.MyCode.Nodes
{
    class Car : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public Car(ITree tree, MyNameSpace nameSpace)
        {
            data = tree.Text;
            this.nameSpace = nameSpace;
            children = new List<INode>();
            if (tree.ChildCount > 0)
                for (int i = 0; i < tree.ChildCount; i++)
                {
                    children.Add(ParseANTLRText.GetNode(tree.GetChild(i), nameSpace));
                }
            execute();
        }

        public void execute()
        {
            children[0].execute();
            String line = children[0].result;
            string[] arrline =line.Split();
            if (arrline.Length > 1)
                result = arrline[0];
            else
                result = "ERROR: "+line+" is not a list";
        }
    }
}
