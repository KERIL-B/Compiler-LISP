using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class BoolOperation : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public BoolOperation(ITree tree, MyNameSpace nameSpace)
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
            try
            {
                double x = Convert.ToDouble(children[0].result);
                double y = Convert.ToDouble(children[1].result);
                
                if (x > y) result = "true";
                else result = "false";
            }
            catch (Exception)
            {
                result = "ERROR: cant compare";
            }
        }
    }
}
