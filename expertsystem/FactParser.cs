using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class FactParser:XMLParser
    {
        private List<string> facts;
        private FactRepository house,flat;

        public FactParser()
        {
           // this.facts = loadXmlDocument("somepath");
        }
        public override void loadXmlDocument(string XmlPath)
        {
            /*XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlPath);
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
            */ 
        }
        public FactRepository GetFactRepository()
        {
            return null; 
        }
    }
}
