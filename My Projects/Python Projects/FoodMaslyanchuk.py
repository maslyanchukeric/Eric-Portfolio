import time, os

#Test 1

#Loop Variable
more = "y"

#Loop beings
while more.lower() == "y":

    #Greeting
    print ("Welcome to Hendrix Food Truck")

    #Food Plates

    #menu
    print("\t**************************************")
    print("\t****           MENU          *********")
    print("\t**** 1. Wings            $20 *********")
    print("\t**** 2. Chicken Strips   $15 *********")
    print("\t**** 3. Fish Basket      $15 *********")
    print("\t**** 4. Shrimp Po Boy    $20 *********")
    print("\t**** 5. Pork Chop Basket $18 *********")
    print("\t**************************************")
    print()
    print()

    #Users Name
    name = input ("What is your name? ")
    print()

    #User orders food
    choice = int(input(f"{name}, please select what number you would like to order? "))
    print()

    #Determine the price
    if choice == 1:
        cost = 20 
        
    elif choice == 2:
        cost = 15
        
    elif choice == 3:
        cost = 15 

    elif choice == 4:
        cost = 20
        
    elif choice == 5:
        cost = 18
        
    else:
        print("Invalid choice, please select a valid option.")
        continue

    #Calculate tax
    tax = 0.09
    total_cost = cost *(1 + tax)

    #Determine if user wants to add a tip
    tip = input(f"{name}, would you like to leave a tip? (y or n): ")
    print()

    if tip.lower() == "y":
        tip = float(input("How much would you like to tip? $"))
        total_cost += tip
                      
    else:
        tip = 0

    #Display Total
    print (f"{name}, you owe ${total_cost:.2f} ")
    print ()
    print ()

    time.sleep(2)

    more = input("Do you want to make another order? (y or n)")
    print()

    os.system('cls')

#Display Thank You
print("Thank You For Ordering!")
print()

time.sleep(5)

    
                      
                      









