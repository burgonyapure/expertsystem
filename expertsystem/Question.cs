using System;
using System.Collections.Generic;
using System.Text;

namespace expertsystem
{
    class Question
    {
        public string id { get; set; }
        public string question { get; set; }
        public Answer answer { get; set; }

        public Question(string id, string question ,Answer answer)
        {
            this.id = id;
            this.question = question;
            this.answer = answer;
        }
        public bool getEvaluatedAnswer(string input)
        {
            //Answer fakeAnswer = new Answer();
            //return fakeAnswer.evaluateAnswerByInput(input);
            return true;
        }
            
    }
}
