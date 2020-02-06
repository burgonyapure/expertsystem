using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace expertsystem
{
    class RuleParser : XMLParser
    {
        private RuleRepository ruleRepo;
        
        public RuleParser()
        {
            loadXmlDocument("Rules.xml");
            ruleRepo = new RuleRepository();
            foreach (XmlNode node in doc.DocumentElement)
            {
                Answer answer = new Answer();
                Question question = new Question("", "", answer);
                ruleRepo.addQuestion(question);
            }
        }

        public RuleRepository GetRuleRepository()
        {
            return ruleRepo;
        }
    }
}
