using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace expertsystem
{
    class FactParser : XMLParser
    {
       
        private List<Fact> ReadFacts()
        {
            loadXmlDocument("Facts.xml");

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
            
            return facts;
        }
    }
}