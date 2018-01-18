using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class Name : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }

        public bool isFunc { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public Name(ITree tree, MyNameSpace nameSpace)
        {
            this.nameSpace = nameSpace;
            data = tree.Text;
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
            foreach (Variable var in nameSpace.vars)
            {
                if (var.name == data)
                {
                    result = var.value;
                    return;
                }
                else
                    result = "ERROR: unknown var";
            }
        }
    }
}
