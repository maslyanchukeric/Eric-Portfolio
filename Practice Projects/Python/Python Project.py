import time
import os

# Function for menu
def tire_menu():
    print('\n')
    print('\tWelcome to America Tire Company')
    print('\t------------------------------ ')
    print('\tTire                Price      ')
    print('\t------------------------------ ')
    print('\tMichelin               240.00  ')
    print('\tGoodyear               155.00  ')
    print('\tBridgestone            180.00  ')
    print('\tSummit                  95.00  ')
    print('\tContinental            160.00  ')
    print('\t-------------------------------')
    print('\n')

# Dictionary
tire_price = {
    'Michelin': 240.00,
    'Goodyear': 155.00,
    'Bridgestone': 180.00,
    'Summit': 95.00,
    'Continental': 160.00
}

# Function for tax calculation
def tax_calculation(base_price):
    tax = base_price * 0.07
    total_price = base_price + tax
    return tax, total_price

# Main Program below

# Variable for loop
new_customer = "Yes"

# Loop begins
while new_customer.lower() == "yes":

    # Program asks user for name
    name = input("What is your name?:")

    # Display tire menu 
    tire_menu()

    # User chooses tire
    tire = input(f"{name}, what tires would you like to purchase?:")

    # User keys in error
    if tire not in tire_price:
        print(f"{name}, we don't have that tire.")
        continue
    else:
        quantity = int(input("How many tires do you want to purchase? "))

        # Get tire price
        base_price = quantity * tire_price[tire]
        print(f"Tire price is ${base_price:.2f}")
        print ()
        

    # User is asked if they want alignment done
    alignment = input(f"{name}, would you like us to check your alignment for an extra $150? (Yes/No): ").lower()
    if alignment == "yes":
        base_price += 150
        print("Alignment service added: $150.00")
        print()
    else:
        print("No alignment service added.")
        print()

    # Discounts
    is_veteran = input("Are you a veteran (yes/no)? ").strip().lower() == 'yes'
    is_first_responder = input("Are you a first responder (yes/no)? ").strip().lower() == 'yes'
    is_senior = input("Are you over 65 years old (yes/no)? ").strip().lower() == 'yes'

    discount_rate = 0
    if is_veteran:
        discount_rate = max(discount_rate, 0.07)
    if is_first_responder:
        discount_rate = max(discount_rate, 0.06)
    if is_senior:
        discount_rate = max(discount_rate, 0.04)

    discount = base_price * discount_rate
    discounted_price = base_price - discount
    print(f"Discount applied: ${discount:.2f}")
    print(f"Discounted tire price: ${discounted_price:.2f}")

    # Calculate tax and total price
    tax, total_price = tax_calculation(discounted_price)
    print(f"Tax: ${tax:.2f}")
    print(f"Total price: ${total_price:.2f}")

    # Prompt for another customer
    new_customer = input("Is there another customer? (Yes/No): ")
    print("\n")
    
print("Thank you for using America Tire Company!")
time.sleep(3)
        
    


  
