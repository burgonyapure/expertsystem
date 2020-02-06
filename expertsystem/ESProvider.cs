using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    
    class ESProvider
    {
        private FactParser factParser;
        private RuleParser ruleParser;
        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            this.factParser = factParser;
            this.ruleParser = ruleParser;

        }
        public void CollectAnswers()
        {
            RuleRepository ruleRepository = ruleParser.GetRuleRepository();
            IEnumerator<Question> enumerator = ruleRepository.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
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
