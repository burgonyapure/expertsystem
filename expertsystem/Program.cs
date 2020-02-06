using System;
using System.Collections.Generic;

namespace expertsystem
{
    class Program
    {
        static void Main(string[] args)
        {

            RuleParser ruleParser = new RuleParser();
            FactParser factParser = new FactParser();
            ESProvider esProvider = new ESProvider(factParser,ruleParser);
            ruleParser.readRules();
            esProvider.CollectAnswers();

           
        }
    }
}
