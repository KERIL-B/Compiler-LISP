using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;

namespace MathLang.MyCode.Nodes
{
    class MathOperation : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }

        public MathOperation(ITree tree, MyNameSpace nameSpace)
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
            switch (data)
            {
                case "+": 
                    Sum();
                    break;
                case "*":
                    Mult();
                    break;
            }
                    }
        private void Mult()
        {
            double num = 1;
            foreach (INode node in children)
            {
                try
                {
                    num *= Convert.ToDouble(node.result);
                }
                catch (Exception)
                {
                    bool exist = false;
                    foreach (Variable var in nameSpace.vars)
                    {

                        if (node.data == var.name)
                        {
                            num *= Convert.ToDouble(var.value);
                            exist = true;
                        }

                    }
                    if (!exist)
                    {
                        result = "ERROR: unknown var";
                        return;
                    }
                }
            }
            result = num + "";
        }


        private void Sum()
        {
            double num = 0;
            foreach (INode node in children)
            {
                try
                {
                    num += Convert.ToDouble(node.result);
                }
                catch (Exception)
                {
                    bool exist = false;
                    foreach (Variable var in nameSpace.vars)
                    {
                        
                        if (node.data == var.name)                           
                            {                   
                                num += Convert.ToDouble(var.value);
                                exist = true;
                            }
                            
                    }
                    if (!exist)
                    {
                        result = "ERROR: unknown var";
                        return;
                    }
                }
            }
            result = num+"";
        }
    }
}
