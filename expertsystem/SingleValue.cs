using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class SingleValue : Value
    {
        string param;
        bool selectionType;
        public SingleValue(string param,bool selectionType)
        {
            this.param = param;
            this.selectionType = selectionType;
        }
        public override List<string> getInputPattern()
        {
            List<string> inputPattern = new List<string>();
            inputPattern.Add(param);
            return inputPattern;
        }
        public override bool getSelectionType()
        {
            return selectionType;
        }
    }
}
