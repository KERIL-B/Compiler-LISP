using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;

using MathLang.MyCode;

namespace MathLang.MyCode.Nodes
{
    class BLOCK : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public BLOCK(ITree tree, MyNameSpace nameSpace)
        {
            string info = "";

            this.nameSpace = nameSpace;
            data = tree.Text;
            children = new List<INode>();
            if (tree.ChildCount > 0)
                for (int i = 0; i < tree.ChildCount; i++)
                {
                    if ((nameSpace.name != "BLOCK") && (i == 0))
                    { }
                    else
                    {
                        INode child = ParseANTLRText.GetNode(tree.GetChild(i), nameSpace);
                        if (child != null)
                        {
                            children.Add(child);
                        }
                        else { Console.WriteLine("ERROR: unknown func"); return; }
                    }
                }
            execute();

        }

        public void execute()
        {
            string info = "";

            foreach (INode node in children)
            {
                if (node.data == "defun")
                    info += (node as Defun).signature + "\n";
                else
                    info += node.result + "\n";
            }

            result = info;

        }

    }
}
