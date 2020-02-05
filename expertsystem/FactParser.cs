using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace expertsystem
{
    class FactParser : XMLParser
    {   
        public FactRepository GetFactRepository()
        {
            return null;
        }
        public static void ReadFacts(Dictionary<string, string> factDict)
        {
            XmlDocument doc = XMLParser.loadXmlDocument("Facts.xml");
            List<Fact> facts = new List<Fact>();
            List<bool> Eval = new List<bool>();
            
            foreach (XmlNode factNode in doc.DocumentElement.ChildNodes)
            {
                
                string factId = factNode.Attributes["id"].Value;
                string descValue = null;
                foreach (XmlNode descNode in factNode.ChildNodes)
                {
                    List<bool> evals = new List<bool>();
                    if (descNode.Name.Equals("Evals"))
                    {
                        
                        foreach (XmlNode evalNode in descNode.ChildNodes)
                        {
                            evals.Add(Convert.ToBoolean(evalNode.InnerText));
                        }
                        
                    }
                    else
                    {
                        descValue = descNode.Attributes["value"].Value;
                    }
                    Eval = evals;
                    
                }
                Fact fact = new Fact(factId, descValue, Eval);
                facts.Add(fact);
            }
            foreach(Fact fact1 in facts)
            {
                Console.WriteLine(fact1.description);
                Console.WriteLine("{0},{1}",fact1.evals[0],fact1.evals[1]);
               
            }
            
            Console.ReadLine();
        }
    }
}
