using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class Cons : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public Cons(ITree tree, MyNameSpace nameSpace)
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
            foreach (INode child in children)
            {
                child.execute();
            }

            String argument1 = children[0].result;
            string[] arg1Arr = argument1.Split();


            String argument2 = children[1].result;
            string[] arg2Arr = argument2.Split();

            if (arg1Arr.Length != 1)
                result = "ERROR: 1st arg is not atom";
            else
                if (arg2Arr.Length > 1)
                {
                    string line = "";
                    for (int i = 0; i < arg2Arr.Length; i++)
                        line += arg2Arr[i] + " ";
                    result = arg1Arr[0] + " " + line;
                }
                else result = "ERROR: 2nd arg is not list";
        }
    }
}
