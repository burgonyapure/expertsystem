using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class RuleRepository : IEnumerator<Question>
    {

        public Dictionary<string, string> ruleRepo = new Dictionary<string, string>();

        public Question Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void addQuestion(Question question)
        {
            ruleRepo[question.id] = question.question;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        internal IEnumerator<Question> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
