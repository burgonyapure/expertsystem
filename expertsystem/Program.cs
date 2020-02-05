using System;
using System.Collections.Generic;

namespace expertsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FactParser fact = new FactParser();
            RuleParser rule = new RuleParser();
            ESProvider esp = new ESProvider(fact,rule);
        }
    }
}
