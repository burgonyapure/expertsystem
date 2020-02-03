using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class ESProvider
    {
        FactParser fact = new FactParser();
        RuleParser rule = new RuleParser();
        public ESProvider(FactParser fact,RuleParser rule)
        {
            this.fact = fact;
            this.rule = rule;
        }
    }
}
