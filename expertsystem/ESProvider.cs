using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    
    class ESProvider
    {
        private Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>();
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
                //Console.WriteLine(enumerator.Current.id);
                Console.WriteLine(enumerator.Current.question);
                string input = Console.ReadLine();
                questionsAndAnswers[enumerator.Current.id] = input;
            }
            //foreach(KeyValuePair<string,string> a in questionsAndAnswers)
            //{
            //    Console.WriteLine("{0},{1}",a.Key,a.Value);
            //}
        }
        public bool GetAnswersByQuestion(string questionID)
        {
            return true;
        }
        public void Evaluate()
        {
            List<Fact> asd = new List<Fact>();
            asd = factParser.ReadFacts();
            int i = 0;
            List<bool> ans = new List<bool>();
            foreach(KeyValuePair<string,string> a in questionsAndAnswers)
            {
                Console.WriteLine(a.Value);
                if (a.Value == "yes")
                {
                    ans.Add(true);
                }
                else if (a.Value == "no")
                {
                    ans.Add(false);
                }
                else { Console.WriteLine("yes or no"); }

                Console.WriteLine(asd[i].description);
                i++;
            }
            int e = 0;
           
            bool kaka = false;
            foreach (Fact fact in asd)
            {
                
               
                bool found = false;
                
                foreach (bool eval in fact.evals)
                {
                    int k = 0;
                    while (eval == ans[k])
                    {
                        found = true;
                        kaka = found;
                        k++;
                        e = k;
                        if (k == ans.Count) { break; }
                        
                    }
                    //Console.WriteLine("{0},{1}", eval, ans[k]);
                   
                }
                
            }
            if (kaka)
            {
                Console.WriteLine(asd[e].description);
            }
            else { Console.WriteLine("asd"); }



        }
    }
}
