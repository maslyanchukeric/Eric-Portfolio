import time

# Function 1: Greeting
def greeting():
    print("Welcome to SCC Shipping")
    print()
    print()

# Function 2: Display Shipping Costs
def shipping_cost(): 
    print("\t\t**** Shipping Option       Cost   ****")
    print("\t\t****        5              7.40   ****")
    print("\t\t****        6              7.70   ****")
    print("\t\t****        7              8.00   ****")
    print("\t\t****        8              7.90   ****")
    print("\t\t****        9              13.75  ****")
    print("\t\t****        10             19.30  ****")
    print()
    print()

# Function 3: Calculate Insurance Cost
def calculate_insurance(amt):
    if amt <= 50:
        return 2.20
    elif amt <= 100:
        return 2.45
    elif amt <= 200:
        return 3.50
    else:
        return 4.60

# Dictionary of shipping rates
shipping_rate = {
    5: 7.40,
    6: 7.70,
    7: 8.00,
    8: 7.90,
    9: 13.75,
    10: 19.30
}

# Main program
repeat_loop = "yes"

while repeat_loop.lower() == "yes":
    # Greeting
    greeting()

    # Display Shipping Menu
    shipping_cost()

    # Ask user for the shipping option
    package_type = input("What type of package do you wish to ship? (Enter number 5-10): ")

    try:
        package_type = int(package_type)
    except ValueError:
        print("Please enter a valid number between 5 and 10.")
        continue

    if package_type not in shipping_rate:
        print("Please enter a number between 5 and 10.")
        continue

    cost = shipping_rate[package_type]

    # Ask if the user wants insurance
    insurance = input("Do you want insurance for the package? (y or n): ").lower()
    
    if insurance == "y":
        try:
            amt = float(input("How much insurance coverage do you want? ($): "))
        except ValueError:
            print("Please enter a valid amount for insurance.")
            continue
        price = calculate_insurance(amt)
    else:
        price = 0

    total = price + cost

    print(f"Your total cost is ${total:,.2f}")
    print()

    repeat_loop = input("Would you like to make another shipping order? (yes or no): ")
    print()
    time.sleep(2)

print("End of program. Have a good day!")

    
    
        
    
        
    










