using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang.MyCode.Nodes
{
    class MyNameSpace
    {
        public string name { get; set; }
        public List<Variable> vars {get;set;}
        public List<Defun> funcs { get; set; }

        public MyNameSpace(string name)
        {
            this.name = name;
            vars=new List<Variable>();
            funcs = new List<Defun>();
        }

        public void AddVar(Variable x)
        {
            foreach (Variable var in vars)
            {
                if (var.name == x.name)
                {
                    var.value = x.value;
                    return;
                }
            }
            vars.Add(x);
        }

        public void PrintVars()
        {
            Console.WriteLine("namespace " + name);
            foreach (Variable var in vars)
            {
                Console.WriteLine(var.name + " = " + var.value);
            }
        }

        public void PrintFuncs()
        {
            Console.WriteLine("namespace " + name);
            foreach (Defun func in funcs)
            {
                Console.WriteLine(func.name + " - " + func.block.Text);
            }
        }
    }
}
