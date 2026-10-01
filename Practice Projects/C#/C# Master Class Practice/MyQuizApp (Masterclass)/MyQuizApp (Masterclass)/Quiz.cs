using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp__Masterclass_
{
    internal class Quiz
    {
        //golbal prperties
        private Question[] _questions; //array of questions
        private int _score { get; set; } //property to keep track of the score
        //constructor
        public Quiz(Question[] questions)
        {
            //initialize the questions array
            this._questions = questions;
        }


        //method to start the quiz
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");

            int questionNumber = 1; //initialize the question number and display the question number

            //loop through the questions array and display each question
            foreach(Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:"); //display the question number and iterate the question number for the next question
                DisplayQuestion(question); //display the question

                int userChoice = GetUseerChoice(); //get the user's answer

                //check if the user's answer is correct using the IsCorrectAnswer method from the Question class
                if (question.IsCorrectAnswer(userChoice))
                {
                    //if the user's answer is correct, display a message
                    Console.WriteLine("Correct!");

                    _score++; //increment the score
                }
                else
                {
                    //if the user's answer is incorrect, display the correct answer
                    Console.WriteLine("Incorrect!" + $" The correct answer is {question.Answer[question.CorrectAnswerIndex]}");
                }
            }

            DisplayResult(); //display the final score after each question
        }

        private void DisplayResult()
        {
            //set the console text color to yellow for the question text
            Console.ForegroundColor = ConsoleColor.Magenta; //set the console text color to yellow for the question text
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor(); //reset the color to default

            //display the final score
            Console.WriteLine($"Quiz Finished! Your final score is: {_score} out of {_questions.Length}");

            double percentage = ((double)_score / _questions.Length) * 100; //calculate the percentage score
            if(percentage >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green; //set the console text color to green for the question text
                Console.WriteLine("Great Work!");
            }
            else if(percentage >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //set the console text color to yellow for the question text
                Console.WriteLine("Good Effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; //set the console text color to red for the question text
                Console.WriteLine("Better Luck Next Time!");
            }

            Console.ResetColor(); //reset the color to default
        }


        //method to display the question
        private void DisplayQuestion(Question question)
        {
            //set the console text color to yellow for the question text
            Console.ForegroundColor = ConsoleColor.Yellow; //set the console text color to yellow for the question text
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor(); //reset the color to default
            //display the question text
            Console.WriteLine(question.QuestionText);

            //display the answer choices
            for(int i = 0; i < question.Answer.Length; i++)
            {
                //display the answer choice with a number
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   "); //line break for better formatting
                Console.Write(i + 1); //display the number of the answer choice
                Console.ResetColor(); //reset the color to default
                Console.WriteLine($". {question.Answer[i]}"); //display the answer choice text
            }
        }

        //getting the user's answer
        private int GetUseerChoice()
        {
            //prompt the user for their answer
            Console.Write("Your answer (number): ");

            //get the user's input
            string input = Console.ReadLine();

            //validate the user's input
            int choice = 0;

            //loop until the user enters a valid input
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                //if the input is invalid, prompt the user again
                Console.WriteLine("Invalid input. Please enter a valid number. Enter number between 1 and 4");

                //get the user's input again
                input = Console.ReadLine();
            }

            //return the user's choice
            return choice -1;//subtract 1 to match the index of the answer array bc of adding 1 to the display of the answer choices
        }

    }
}
