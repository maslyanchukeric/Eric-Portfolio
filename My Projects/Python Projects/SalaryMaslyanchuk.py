import time, os

# Function 1
def greeting():
    print("Welcome to Human Resources")
    print()
    print()

# Function 2
def rating_chart():
    print("**********************************")
    print("           Rating Chart           ")
    print("**********************************")
    print("           E - Excellent          ")
    print("           S - Satisfactory       ")
    print("           U - Unsatisfactory     ")
    print("**********************************")
    print("**********************************")

# Function 3
def salary_percentage():
    print("\t\t**** Employee Classification        Salary Percentage ****")
    print("\t\t****         1                            2.0%        ****")
    print("\t\t****         2                            3.5%        ****")
    print("\t\t****         3                            2.5%        ****")
    print("\t\t****         4                            3.0%        ****")
    print("\t\t****         5                            1.0%        ****")
    print()
    print()

# Dictionary for salary increase percentages
def calculate_salary_increase(classification):
    salary_increases = {
        1: 0.02,  # 2.0%
        2: 0.035, # 3.5%
        3: 0.025, # 2.5%
        4: 0.03,  # 3.0%
        5: 0.01   # 1.0%
    }
    return salary_increases.get(classification, None)

# Main Program
greeting()

more_employees = "yes"

while more_employees.lower() == "yes":

    employee_ID = input("Enter Employee ID: ")
    
    # Display the rating chart
    rating_chart()
    print()
    
    performance_rating = input("Enter Employee Rating (E, S, U): ").strip().upper()
    print() 
    
    if performance_rating in ["E", "S"]:
        
        try:
            salary_percentage()
            classification = int(input("Enter Employee's Classification (1 - 5): "))
            print()
            
            base_salary_input = input("Enter Employee's Salary: ").replace(',', '').strip()
            base_salary = float(base_salary_input)

            # Calculate the new salary
            increase_percent = calculate_salary_increase(classification)
            if increase_percent is not None:

                # Calculate increase amount and new salary
                increase_amount = base_salary * increase_percent
                new_salary = base_salary + increase_amount

                # Display results
                print(f"\nEmployee Number: {employee_ID}")
                print(f"Current Salary: ${base_salary:,.2f}")
                print(f"Increase Percentage: {increase_percent * 100:.1f}%")
                print(f"Salary Increase Amount: ${increase_amount:.2f}")
                print(f"New Salary: ${new_salary:.2f}")

            else:
                print("Invalid classification. Please enter a number between 1 and 5.")

        except ValueError:
            print("Invalid input. Please enter numerical values for classification and salary.")

    elif performance_rating == "U":
        
        # Performance Rating is "Unsatisfactory"
        print(f"\nEmployee Number: {employee_ID}")
        print("Performance Rating: Unsatisfactory")
        print("Employee will be on probation for a year.")

    else:
        print("Invalid performance rating. Please enter 'E', 'S', or 'U'.")

    more_employees = input("Do you want to enter another employee? (Yes or No): ")
    if more_employees.lower() == "yes":
        time.sleep(2)
        os.system('cls' if os.name == 'nt' else 'clear')  # Clear the console (cross-platform)

# Display Thank You and exit the program
print("Exiting Program")
print("Thank You!")
print()
time.sleep(5)

 





    
        
        
    




    
    
    
                     










    
    
    

