using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class MultipleValue : Value
    {
        List<string> parameters;
        bool selectionType;
        public MultipleValue(List<string> parameters, bool selectionType)
        {
            this.parameters = parameters;
            this.selectionType = selectionType;
        }

        public override List<string> getInputPattern()
        {
            return parameters;
        }

        public override bool getSelectionType()
        {
            return selectionType;
        }
    }
}
