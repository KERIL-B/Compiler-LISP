using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class If : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }
        private ITree tree;

        public If(ITree tree, MyNameSpace nameSpace)
        {
            this.tree = tree;
            data = tree.Text;
            this.nameSpace = nameSpace;
            result = "";
            children = new List<INode>();
            execute();
        }

        public void execute()
        {
            INode compareChild = ParseANTLRText.GetNode(tree.GetChild(0), nameSpace);
            if (compareChild.result.Length < 6)
            {
                bool compareRez = StringToBool(compareChild.result);

                if (compareRez)
                {
                    INode child = ParseANTLRText.GetNode(tree.GetChild(1), nameSpace);
                    result = child.result;
                }
                else
                    if (tree.ChildCount > 1)
                    {
                        INode child = ParseANTLRText.GetNode(tree.GetChild(2), nameSpace);
                        result = child.result;
                    }
            }
            else
            {
                result = children[0].result;
            }
        }

        private bool StringToBool(string x)
        {
            if (x == "true") return true;
            if (x == "false") return false;
            return false;
        }
    }
}
