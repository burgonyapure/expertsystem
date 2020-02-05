using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    
    class ESProvider
    {
        private FactParser factParser;
        private RuleParser ruleParser;
        public ESProvider(FactParser factParser, RuleParser ruleparser)
        {
            this.factParser = factParser;
            this.ruleParser = ruleparser;

        }
        public void CollectAnswers()
        {
            
        }
        public bool GetAnswersByQuestion(string questionID)
        {
            return false;
        }
        public string Evaluate()
        {
            return "LOL";
        }
    }
}
