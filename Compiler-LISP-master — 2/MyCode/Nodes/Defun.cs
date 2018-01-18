using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class Defun : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }
        public string name { get; set; }

        public ITree block { get; set; }

        public string signature { get; set; }

        bool VarOK = true;

        public Defun(ITree tree, MyNameSpace blockNameSpace)
        {

            data = tree.Text;


            children = new List<INode>();

            ITree funcSign = tree.GetChild(0);
            name = funcSign.Text;
            this.nameSpace = new MyNameSpace(name);
            result = "defun " + name + " (";
            for (int i = 0; i < funcSign.ChildCount; i++)
            {
                string varName = funcSign.GetChild(i).Text;
                nameSpace.vars.Add(new Variable(varName, null));
                result += varName + " ";
            }
            result += ")";

            signature = result;

            block = tree;

            CheckVars(block);

            if (VarOK)
                blockNameSpace.funcs.Add(this);
        }

        public void execute()
        {
            BLOCK Funblock = new BLOCK(block, nameSpace);
            result = Funblock.result;
        }

        private void CheckVars(ITree tree)
        {
            if (tree.ChildCount > 0)
                for (int i = 0; i < tree.ChildCount; i++)
                {
                    if ((tree == block) && (i == 0))
                    { }
                    else
                        CheckVars(tree.GetChild(i));
                }
            else
            {
                INode node = ParseANTLRText.GetNode(tree, nameSpace);
                if (node is Name)
                {
                    string varName = node.data;
                    if (!existVar(varName))
                    {
                        result = "ERRRO: unknown var";
                        VarOK = false;
                        return;
                    }
                }
            }
        }

        private bool existVar(string name)
        {
            foreach (Variable var in nameSpace.vars)
                if (var.name == name)
                    return true;
            return false;
        }
    }
}
