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
            //loadXmlDocument("Rules.xml");
            //ruleRepo = new RuleRepository();
            //foreach (XmlNode node in doc.DocumentElement)
            //{
            //    Console.WriteLine(node.Name);
            //    Answer answer = new Answer();
            //    Question question = new Question("", "", answer);
            //    ruleRepo.addQuestion(question);
            //}
        }

        public void test()
        {
            loadXmlDocument("Rules.xml");
            ruleRepo = new RuleRepository();
            foreach (XmlNode node in doc.DocumentElement)
            {
                string ájdí = null;
                string q = null;
                ájdí = node.Attributes["id"].Value;
                bool abool = true;
                List<string> inputPattern = new List<string>();
                foreach(XmlNode qu in node)
                {
                    if (qu.Name == "Question")
                    {
                        q = qu.InnerText;
                    }
                    else if (qu.Name == "Answer")
                    {
                       foreach(XmlNode an in qu)
                        {
                            
                            abool = Convert.ToBoolean(an.Attributes["value"].Value);
                            foreach (XmlNode inpPattern in qu)
                            {
                                inputPattern.Add(inpPattern.Attributes["value"].Value);
                            }
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cannot happen");
                    }
                }
                Answer answer = new Answer(abool,inputPattern);
                Question question = new Question(ájdí, q, answer);
                
                //ruleRepo.addQuestion(question);
                
            }
        }

        public RuleRepository GetRuleRepository()
        {
            return ruleRepo;
        }
    }
}
