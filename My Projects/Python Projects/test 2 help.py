import time

# Function 1: Greeting
def greeting():
    print("Welcome to Human Resources")
    print()
    print()

# Function 2: Display Rating Chart
def rating_chart():
    print("**********************************")
    print("           Rating Chart           ")
    print("**********************************")
    print("           E - Excellent          ")
    print("           S - Satisfactory       ")
    print("           U - Unsatisfactory     ")
    print("**********************************")
    print("**********************************")
    print()

# Function 3: Display Salary Percentage Chart
def salary_percentage():
    print("\t\t**** Employee Classification        Salary Percentage ****")
    print("\t\t****         1                            2.0%        ****")
    print("\t\t****         2                            3.5%        ****")
    print("\t\t****         3                            2.5%        ****")
    print("\t\t****         4                            3.0%        ****")
    print("\t\t****         5                            1.0%        ****")
    print()
    print()

# Function 4: Calculate Salary Adjustment Percentage
def calculate_salary(classification):
    if classification == 1:
        return 0.02
    elif classification == 2:
        return 0.035
    elif classification == 3:
        return 0.025
    elif classification == 4:
        return 0.03
    elif classification == 5:
        return 0.01
    else:
        return 0.0  

# List of valid performance ratings
performance_rating = ["E", "S", "U"]

# Main Program
greeting()

# Prompt the clerk to enter an employee number
employee_num = input("Please enter employee number: ")
print()

# Display the rating chart and prompt for the employee's performance rating
rating_chart()
rating = input("Please enter employee rating (E, S, U): ").upper().strip()
print()

if rating in ["E", "S"]:
    try:
        current_salary = float(input("Please enter employee's base salary: $"))
        print()
    except ValueError:
        print("Invalid input for base salary. Please enter a numeric value.")
        exit()

    # Display the salary percentage chart and prompt for the employee classification
    salary_percentage()
    try:
        classification = int(input("Please enter Employee Classification using the menu above (1-5): "))
        if classification not in range(1, 6):
            print("Invalid classification. Please enter a number between 1 and 5.")
            exit()
        print()
    except ValueError:
        print("Invalid input for classification. Please enter a number between 1 and 5.")
        exit()

    # Calculate the salary adjustment
    percentage = calculate_salary(classification)
    adjusted_salary = current_salary * (1 + percentage)

    # Display the results
    print(f"Employee Number: {employee_num}")
    print(f"Performance Rating: {rating}")
    print(f"Base Salary: ${current_salary:,.2f}")
    print(f"Classification: {classification}")
    print(f"Salary Increase Percentage: {percentage*100:.2f}%")
    print(f"New Adjusted Salary: ${adjusted_salary:,.2f}")
else:
    print("Employee will be on probation for a year due to Unsatisfactory rating.")
    print(f"Employee Number: {employee_num}")
    print(f"Performance Rating: {rating}")

print()
print("End of program. Have a good day!")
