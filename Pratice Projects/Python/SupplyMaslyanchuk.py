import time, os

#Supply Kit Program

# Function to calculate the supply cost
def calculate_supply_cost(kit_num):
        if kit_num == 1:
            return 299.00
        elif kit_num == 2:
            return 99.00
        elif kit_num == 3:
            return 699.00
        elif kit_num == 4:
            return 199.00
        elif kit_num == 5:
            return  250.00
        else:
            print("Invalid number! Enter numbers 1 - 5")
            return 0.00

# Loop Variable 
repeat_loop = "yes"

# Main Loop begins
while repeat_loop.lower() == "yes":
    
    # Greeting
    print("Welcome to Chaser's BookInn")
    print()
    print()
    
    # User Supply Kit Menu
    print("\t*****************************************")
    print("\t******* 1. Mechatronics Kit      $299****")
    print("\t******* 2. Nursing Kit            $99****")
    print("\t******* 3. Welding Kit           $699****")
    print("\t******* 4. Multimeter            $199****")
    print("\t******* 5. Culinary Kit          $250****")
    print("\t*****************************************")
    print()
    print()
    
    # Ask user for name
    name = input("What is your name? ")
    print()

    # List to store the kit numbers
    selected_kits = []

    # Nested Loop begins
    while True:
        
        # Ask user what kit they would like to purchase
        kit_num = int(input("Enter the number that you would like to purchase: "))
        print()
        if kit_num not in range(1, 6):
            print("Invalid number. Please enter a number from 1 to 5")
            continue
        
        #selected kits added into list 
        selected_kits.append(kit_num)

        # Ask user if they want another kit
        more_kits = input("Would you like to get another Kit? (yes or no) ")
        print()
        
        if more_kits.lower() != "yes":
            break

        print()

    # Calculate total cost
    total_cost = sum(calculate_supply_cost(kit_num) for kit_num in selected_kits)
        
        # Ask user if they are in TRIO program
    TRIO = input("Are you in the TRIO program (yes or no)? ").lower()
    print()
    
    if TRIO == "yes":
        # Calculate 50% discount
        total_cost *= 0.5

    # Calculate tax
    total_cost *= 1.07

    #Display total for user 
    print(f"{name}, your total bill including tax is: ${total_cost:.2f}")
    print()

    #question asks if user want to buy another kit.
    repeat_loop = input("Would like to make another purchase? (yes or no): ")
    print()

    time.sleep(2)
    os.system('cls')

#Thanks Output
print("Thanks for shopping at the Chaser's  BookInn!")

time.sleep(5)
os.system('cls')

        
        
        
        
        
        
            
            

            
            
        
        
        
    
   

    
         
