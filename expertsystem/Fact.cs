using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class Fact
    {
        public string id;
        public string description;
        public List<bool> evals;
        public Fact(string id,string description, List<bool> evals)
        {
            this.id = id;
            this.description = description;
            this.evals = evals;
        }
    }
}
