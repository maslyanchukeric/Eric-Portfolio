import time, os

#Breakfest Program

#Function 2
def greeting():
    print ("Welcome to SCC Student HUB CAFE!")
    print()
    print()

#Function 2
def print_header():
    print("\t\t****          MENU                ****")
    print("\t\t**** 1.Specialty Donut    $1.50   ****")
    print("\t\t**** 2.Bagel              $3.15   ****")
    print("\t\t**** 3.Croissant          $2.98   ****")
    print("\t\t**** 4.English Muffin     $1.75   ****")
    print("\t\t**** 5.Coffee             $2.99   ****")
    print("\t\t**** 6.Juice              $1.99   ****")
    print()
    print()

#Dictionary
food_dic = {
    1: 1.50,
    2: 3.15,
    3: 2.98,
    4: 1.75,
    5: 2.99,
    6: 1.99
    }


#Main
#loop variable
order = "yes"

#Loop Begins
while order.lower() == "yes":

    #Greeting
    greeting()
   
    #Menu
    print_header()

    #Ask for users name
    name = input ("What is your name? ")
    print()

    #nested loop
    another_order = "yes"

    total = 0

    #list of purchased items
    """items_purchased =[]"""
    
    #nested loop begins
    """User wants more then just one order"""
    while another_order.lower() == "yes":
        
        # Ask user what they would like to order
        item_number = int(input("What item would you like to order? "))
        print()

        if item_number not in food_dic:
            print("Invalid item number. Please select an item from the menu.")
            continue
    
        #User wants more then just one of item
        qty = int( input (f"{name}, How many orders of {item_number} do you want to get? "))

        
        #adding all items together
        total_items = qty * food_dic[item_number]
        """ items_purchased.append(food_dic[item_number])"""
    
    
        print (f"{name}, your NON TAXED sub total is {total_items:.2f}")
        print ()

        #Accumulator for total items
        total = total + total_items
        """total = sum(item_purchased)"""
        
        #User asked if they would like to get another item
        another_order = input ("Would you like to another item? (yes or no)")
        print()

    #Calculate tax
    total = total * 1.09

    #Display Total
    print(f"{name}, you owe ${total:.2f}")

    #Would user want to make a whole different order.
    order = input ("Would like to place another order? (yes or no)?")

    time.sleep(2)
    os.system('cls')

#Display Thank You
print("Thanks You for Visiting SCC Student HUB CAFE!")
print()
time.sleep(5)

        

        

    

        
    
