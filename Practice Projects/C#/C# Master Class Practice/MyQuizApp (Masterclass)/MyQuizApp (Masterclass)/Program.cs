namespace MyQuizApp__Masterclass_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a question array 
            Question[] questions = new Question[]
            {
                //create a question, and the answers, and the correct answer index
                new Question("What is the capital of Germany?", new string[] { "Paris", "London", "Berlin", "Madrid" }, 2),
                new Question("What is 2 + 2?", new string[] { "3", "4", "5", "6" }, 1),
                new Question("Who wrote 'Hamlet'?", new string[] { "Charles Dickens", "Jane Austen", "Mark Twain", "William Shakespeare" }, 3),
            };
            //create a quiz 
            Quiz myQuiz = new Quiz(questions);

            //display the first question
            myQuiz.StartQuiz();

            //display the answer choices

        }
    }
}
