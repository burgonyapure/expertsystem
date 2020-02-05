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
    }
}
