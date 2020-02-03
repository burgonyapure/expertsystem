using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class ESProvider
    {
        private FactParser fact = new FactParser();
        private RuleParser rule = new RuleParser();

        public ESProvider(FactParser fact,RuleParser rule)
        {
            this.fact = fact;
            this.rule = rule;
        }
        public void CollectAnswer()
        {

        }
        public bool GetAnswersByQuestion()
        {
            return false;
        }
        public string Evaluate()
        {
            return "LOL";
        }
    }
}
