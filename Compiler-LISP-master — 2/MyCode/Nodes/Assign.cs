using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class Assign : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public Assign(ITree tree, MyNameSpace nameSpace)
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
            Console.WriteLine();
            string varName = children[0].data;
            (children[0] as Name).isFunc = false;
            string varValue = children[1].result;

            Variable var = new Variable(varName,varValue);
            nameSpace.AddVar(var);

           // result = varName + "::=" + varValue;    
            result = "";
        }
    }
}
