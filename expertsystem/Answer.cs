using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class Answer
    {
        bool answer;
        List<string> inputPattern;
        public Answer (bool answer, List<string> inputPattern)
        {
            this.answer = answer;
            this.inputPattern = inputPattern;
        }
        //public Answer()
        //{

        //}

        public bool evaluateAnswerByInput(string input)
        {
            Value value;

            //value.InputPattern.Contains(input);
            //   return value.getSelectionType();
            /*
            if (input == "yes")
            {
                return true;
            }
            else if (input == "no")
            {
                return false;
            }
            else throw new Exception("nincs ilyen bazdmeg");*/
            return true;
        }
    }
}
