using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MathLang.MyCode.Nodes;
using Antlr.Runtime.Tree;

namespace MathLang.MyCode
{
    static class ParseANTLRText
    {
        public static MyNameSpace blockNameSpace = new MyNameSpace("BLOCK");

        public static INode GetNode(ITree tree, MyNameSpace nameSpace)
        {
            switch (tree.Text)
            {
                case "'":
                    return new Quote(tree, nameSpace);
                case "car":
                    return new Car(tree, nameSpace);
                case "cdr":
                    return new Cdr(tree, nameSpace);
                case "cons":
                    return new Cons(tree, nameSpace);
                case "::=":
                    return new Assign(tree, nameSpace);
                case "defun":
                    return new Defun(tree, nameSpace);
                case "if":
                    return new If(tree, nameSpace);
                case "+":
                case "-":
                case "*":
                case "/": return new MathOperation(tree, nameSpace);
                case ">": return new BoolOperation(tree, nameSpace);
                default: return ParseCustomItem(tree, nameSpace);
            }
        }

        private static INode ParseCustomItem(ITree tree, MyNameSpace nameSpace)
        {
            bool isNum = false;
            try
            {
                double x = Convert.ToDouble(tree.Text);
                isNum = true;
            }
            catch (Exception) { }

            if (isNum)
                return new Number(tree, nameSpace);
            else
            {
                if (tree.ChildCount > 0)
                {
                    bool isFunc = false;
                    foreach (Defun func in blockNameSpace.funcs)
                    {
                        if (func.name == tree.Text)
                        {
                            isFunc = true;
                            return new ExeFun(tree, func, nameSpace);
                        }
                    }
                    if (!isFunc)
                    {
                        return null; }

                }
                else
                    return new Name(tree, nameSpace);
            }
            return null;
        }
    }
}
