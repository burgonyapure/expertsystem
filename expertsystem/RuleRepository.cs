using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class RuleRepository
    {
        class RuleEnumerator : IEnumerator<Question>
        {
            private int position = -1;
            private readonly Question[] questions;

            public Question Current
            {
                get
                {
                    if (position < 0)
                    {
                        throw new InvalidOperationException();
                    }
                    return questions[position];
                }
            }

            object IEnumerator.Current => throw new InvalidOperationException();

            internal RuleEnumerator(Question[] questions)
            {
                this.questions = questions;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                position++;
                return questions.Length > position;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

        }
        private Dictionary<string, Question> ruleRepo = new Dictionary<string, Question>();


        public void addQuestion(Question question)
        {
            ruleRepo[question.id] = question;
        }

        internal IEnumerator<Question> GetEnumerator()
        {
            var arr = new Question[ruleRepo.Values.Count];
            ruleRepo.Values.CopyTo(arr, 0);
            return new RuleEnumerator(arr);
        }
    }
}
