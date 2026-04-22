import time, os

#BMI Prgram

#loop variable
repeat_loop = 'y'

#loop begins
while repeat_loop.lower() == 'y':
    
    #greeting message
    print("Welcome to the BMI Calculator")
    print()
    
    #Ask user for Name
    name = input("What is your name? ")
    print()
    
    #Ask user for weight in pounds 
    pounds = float (input("How much do you weight in POUNDS? "))
    print()
    
    #user invalid input (pounds)
    if pounds <= 0 or pounds >= 600:
        print("Invalid input for weight. Please enter a correct number.")
        continue

    #Ask user for height in INCHES
    inches = float (input ("What is your height in INCHES? "))
    print ()

    #user invalid input
    if inches <= 0 or inches > 96:
        print("Invalid input for height. Please enter a correct number.")
        continue

    #calculations 
    BMI = (pounds /(inches ** 2)) * 703 
    
    #if statements for BMI
    if BMI <= 18.5:
        print (f"{name}, your BMI is {BMI:,.2f}")
        print(f"{name}, you are UNDERWEIGHT we will have to put you on a weight gainer program.")
        print()
        
    elif BMI <= 24.9:
        print (f"{name}, your BMI is {BMI:,.2f}")
        print(f"{name}, you are HEALTHY keep doing what you are doing!")
        print()

    elif BMI <=29.9:
        print (f"{name}, your BMI is {BMI:,.2f}")
        print(f"{name}, you are OVERWEGIHT we will have to put you on a weight loss program.")
        print()

    else:
        print (f"{name}, your BMI is {BMI:.,2f}")
        print(f"{name}, you are OBESE we must to put you on a strict weight loss program.")
        print()

    #Ask user if you would like to do another calculation.
    repeat_loop = input ("Do you want to calculate BMI again? (y or n): ")
    print()

    time.sleep(2)

    #clear screen
    os.system('cls')


#Thank you output
print ("Thank You, have a blessed day!")

#Pause
time.sleep(5)



         
        
        

    

    
