using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace expertsystem
{
    abstract class XMLParser
    {
        public static void loadXmlDocument(String XmlPath)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlPath);

            List<Fact> facts = new List<Fact>();
            foreach(XmlNode factNode in doc.DocumentElement.ChildNodes)
            {
                string factId = factNode.Attributes["id"].Value;
                foreach (XmlNode descNode in factNode.ChildNodes)
                {
                    string descValue = descNode.Attributes["value"].Value;
                    Fact fact = new Fact(factId, descValue);
                    facts.Add(fact);

                    XmlNode evalsNode = descNode.FirstChild;
                    ////foreach (XmlNode evalNode in evalsNode.ChildNodes)
                    ////{
                    //    string evalId = evalNode.Attributes["id"].Value;
                    //    string evalValue = evalNode.InnerText;
                    //    //fact.SetFactValueById(evalId, evalValue);
                    //}


                }
            }
            /*if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    Console.WriteLine(root.ChildNodes[i].InnerText);
                }
            }*/
            


        }
        

        
    }
}
