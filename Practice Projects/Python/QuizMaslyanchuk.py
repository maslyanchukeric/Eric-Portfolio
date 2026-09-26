import os
import random

# Set the directory where the quiz files will be saved
os.chdir('C:\\Users\\masly\\OneDrive\\Desktop\\School\\Semester 3\\CPT 180\\Labs')

# Dictionary of Python terms and their definitions
pywords = {
    "Variable": "A reserved memory location to store values.",
    "List": "A collection which is ordered and changeable. Allows duplicate members.",
    "Tuple": "A collection which is ordered and unchangeable. Allows duplicate members.",
    "Dictionary": "A collection which is unordered, changeable, and indexed. No duplicate members.",
    "Set": "A collection which is unordered and unindexed. No duplicate members.",
    "String": "A sequence of characters.",
    "Function": "A block of code which only runs when it is called.",
    "Loop": "Used for iterating over a sequence.",
    "Conditional": "Used to perform different actions based on different conditions.",
    "Class": "A code template for creating objects.",
    "Object": "An instance of a class.",
    "Exception": "An event that can disrupt the normal flow of a program.",
    "Module": "A file containing a set of functions you want to include in your application.",
    "Package": "A way of organizing related modules.",
    "Lambda": "A small anonymous function.",
    "Decorator": "A function that takes another function and extends its behavior without explicitly modifying it.",
    "List Comprehension": "A concise way to create lists.",
    "Generator": "A function that returns an iterator that yields a series of values.",
    "Inheritance": "A way to form new classes using classes that have already been defined.",
    "Polymorphism": "The ability to present the same interface for different underlying forms."
}

# Generate 25 quizzes
for quizNum in range(25):
    # Open a new file for each quiz
    quiz_filename = f"Term{quizNum + 1}.txt"
    with open(quiz_filename, 'w') as quizfile:
        # Write the header of the quiz
        quizfile.write((' ' * 20) + f'Python Terms Quiz (Form {quizNum + 1})\n')
        quizfile.write('\nName: _____________________________')
        quizfile.write('\n\nDate: ____________')
        quizfile.write('\n\n')

        # Shuffle the terms to randomize the order of questions
        terms = list(pywords.keys())
        random.shuffle(terms)

        # Loop through all terms and create questions
        for questionNum in range(len(terms)):
            # Get the correct answer for the current term
            correctan = pywords[terms[questionNum]]

            # Get three random incorrect answers
            wrongans = list(pywords.values())
            wrongans.remove(correctan)
            wrongans = random.sample(wrongans, 3)

            # Combine correct and incorrect answers, then shuffle them
            answers = wrongans + [correctan]
            random.shuffle(answers)

            # Write the question and the answer choices to the quiz file
            quizfile.write(f"{questionNum + 1}. What is the definition of '{terms[questionNum]}'?\n")
            for i in range(4):
                quizfile.write(f"    {'ABCD'[i]}. {answers[i]}\n")
            quizfile.write('\n')

print(f"{25} quizzes have been generated successfully.")
