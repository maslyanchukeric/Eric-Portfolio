import 
import os

#function for menu
def robot_menu():
    print ('\n')
    print ('\tWelcome to Robotics Inc. ')
    print ('\tRobot            Price   ')
    print ('\t------------------------ ')
    print ('\tNAO               10000  ')
    print ('\tPepper            28000  ')
    print ('\tRomeo              7500  ')
    print ('\tAtlas              6000  ')
    print ('\tWhiz               4000  ')
    print ('\t------------------------ ')



# Dictionary
robot_prices = {
    'NAO': 10000,
    'Pepper': 28000,
    'Romeo': 7500,
    'Atlas': 6000,
    'Whiz': 4000
    }

#Main program

#main loop
more_customers = "yes"

#loop for more then one customer
while more_customers.lower() == "yes":
    robot_menu()
    print()

    
    #user is asked to pick from a robot
    item = input ("From the menu above what robot would like to order?:")

    if item not in robot_prices:
        print ("We dont have that robot!")
        continue
    else:
        #change the robot price to base pay
        base_pay = robot_prices[item]
        print (f"Robot price is ${base_pay}")
        print ()

    
    

    #user is asked if they want a warranty on robot
    warranty = input ("Would like to purchase a warranty on your robot? (Please choice one: 2 year plane or lifetime plane):")
    if warranty == '2':
        base_pay += 500
    elif warranty == 'lifetime':
        base_pay += 1000
    else:
        base_pay += 0
    print ()
    print (base_pay)

    #user is asked if they want to purchase a training option
    trianing_opt = input ("Would you like to purchase a Training Package? (yes or no):").lower()
    if trianing_opt == 'yes':
        base_pay += 250
    print ()
    print (base_pay)

    #user is asked if they are a Healthercare professional
    healthcare_pro = input ("Are you a healthcare professional? (yes or no):").lower()
    if healthcare_pro == "yes":
        discount = base_pay * 0.20
        base_pay -= discount 
    
    print (f"Subtotal ${base_pay:.2f}")

    #calculate tax
    tax = base_pay * 0.07
    total_price = base_pay + tax
    print(f"Total price with tax: ${total_price:.2f}")
    
    
    
    
    
    

    
