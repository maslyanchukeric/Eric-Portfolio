using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp__Masterclass_
{
    internal class Question
    {
        //properties
        public string QuestionText { get; set; }
        public string[] Answer { get; set; }
        public int CorrectAnswerIndex { get; set; }

        //constructor
        public Question(string questionText, string[] answer, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answer = answer;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        //boolean method to check if the answer is correct
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
