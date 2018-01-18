using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;
using MathLang.MyCode.Nodes;

namespace MathLang.MyCode
{
    class Analyser
    {
        ITree tree;
        public Analyser(ITree tree)
        {
            this.tree = tree;

            BLOCK block = new BLOCK(tree, ParseANTLRText.blockNameSpace);
            Console.WriteLine(block.result);
        }
    }
}
