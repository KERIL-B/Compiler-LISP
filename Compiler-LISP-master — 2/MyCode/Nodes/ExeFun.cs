using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime.Tree;


namespace MathLang.MyCode.Nodes
{
    class ExeFun : INode
    {
        public string data { get; set; }
        public string result { get; set; }
        public List<INode> children { get; set; }
        public MyNameSpace nameSpace { get; set; }
        MyNameSpace nameSpaceParent { get; set; }

        Defun func { get; set; }

        public ExeFun(ITree tree, Defun func, MyNameSpace nameSpaceParent)
        {
            this.nameSpace = func.nameSpace;
            this.nameSpaceParent = nameSpaceParent;
            data = tree.Text;
            this.func = func;
            children = new List<INode>();

            if (tree.ChildCount == func.nameSpace.vars.Count)
                for (int i = 0; i < tree.ChildCount; i++)
                {
                    children.Add(ParseANTLRText.GetNode(tree.GetChild(i), nameSpaceParent));
                }
            else result = "ERROR: wrong func signature";


            execute();
        }
        public void execute()
        {

            if (result != "ERROR: wrong func signature")
            {
                for (int i = 0; i < func.nameSpace.vars.Count; i++)
                {
                    if (children[i] is Name)
                        children[i].result = findResultOfVar(children[i].data);
                    func.nameSpace.vars[i].value = children[i].result;
                }

                func.execute();

                result = func.result;
            }
        }

        private string findResultOfVar(string name)
        {
            foreach (Variable var in nameSpaceParent.vars)
                if (var.name == name)
                    return var.value;
            return "ERROR: unknown var";
        }
    }
}
