using System;
using System.Collections.Generic;

namespace expertsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> factDict = new Dictionary<string, string>();
            FactParser.ReadFacts(factDict);
        }
    }
}
