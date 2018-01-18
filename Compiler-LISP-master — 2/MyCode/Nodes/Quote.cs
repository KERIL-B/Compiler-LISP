using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class Quote : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        List<string> list;

        public Quote(ITree tree, MyNameSpace nameSpace)
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
            list = new List<string>();

            quoteLoop(this);

            list.RemoveAt(0);

            string line = "";

            foreach (string atom in list)
            {
                line += atom+" ";
            }
            
            result = line.Remove(line.Length-1,1);
        }

        private void quoteLoop(INode node)
        {
            list.Add(node.data);
            if (node.children.Count > 0)
                for (int i = 0; i < node.children.Count; i++)
                    quoteLoop(node.children[i]);
        }
    }
}
