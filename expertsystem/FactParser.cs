using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace expertsystem
{
    class FactParser : XMLParser
    {
        Dictionary<string, string> factDict { get; set; }

        public FactRepository GetFactRepository()
        {
            return null;
        }
        public static void ReadFacts()
        {
            XmlDocument doc = XMLParser.loadXmlDocument("Facts.xml");
            List<Fact> facts = new List<Fact>();
            var factDict = new Dictionary<string, string>();
            foreach (XmlNode factNode in doc.DocumentElement.ChildNodes)
            {
                string factId = factNode.Attributes["id"].Value;
                foreach (XmlNode descNode in factNode.ChildNodes)
                {
                    if (descNode.Name.Equals("Evals"))
                    {
                        foreach(XmlNode evalNode in descNode.ChildNodes)
                        {
                            if (factDict.ContainsKey(factId))
                            {
                                
                                factDict[factId] += evalNode.InnerText;
                            }
                            else
                            {
                                
                                factDict.Add(factId, evalNode.InnerText);
                            }
                        }

                    }
                    else
                    {
                        string descValue = descNode.Attributes["value"].Value;
                        Fact fact = new Fact(factId, descValue);
                        facts.Add(fact);

                        XmlNode evalsNode = descNode.FirstChild;
                    }
                }
            }
            foreach(Fact fact1 in facts)
            {
                Console.WriteLine(fact1.description);
            }
            foreach(string keys in factDict.Keys)
            {
                Console.WriteLine(keys);
                Console.WriteLine(factDict[keys]);
            }
        }
    }
}
