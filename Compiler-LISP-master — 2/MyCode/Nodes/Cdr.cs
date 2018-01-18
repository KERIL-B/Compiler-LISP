using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;

namespace MathLang.MyCode.Nodes
{
    class Cdr : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public Cdr(ITree tree, MyNameSpace nameSpace)
        {
            this.nameSpace = nameSpace;
            data = tree.Text;
            result = "";
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
                for (int i = 1; i < arrline.Length; i++)
                {
                    result += arrline[i] + " ";
                }
            else
                result = "ERROR: " + line + " is not a list";
        }
    }
}