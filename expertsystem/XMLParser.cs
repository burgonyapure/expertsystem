using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace expertsystem
{
    abstract class XMLParser
    {
        protected XmlDocument doc;
        public void loadXmlDocument(String XmlPath)
        {

            doc = new XmlDocument();
            doc.Load(XmlPath);

            
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
        

        
    

