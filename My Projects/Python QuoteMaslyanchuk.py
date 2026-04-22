import time
import os

#system changing directory 
#os.chdir('C:\\Users\\masly\\OneDrive\\Desktop\\School\\Semester 3\\CPT 180\\Tests')

def menu():
    print("Welcome to Tech Computer Solutions!")
    print("Available Items and Prices:")
    print("===========================")
    print("Graphics Card    $999.99")
    print("Processor        $549.99")
    print("Solid State      $149.99")
    print("Memory           $89.99")
    print("Motherboard      $349.99")
    print("Power Supply     $149.99")
    print("===========================\n")

# Dictionary of computer parts and their prices
computer_parts = {
    'graphics card': 999.99,
    'processor': 549.99,
    'solid state': 149.99,
    'memory': 89.99,
    'motherboard': 349.99,
    'power supply': 149.99
}

# Main program function

while True:
    os.system('cls' if os.name == 'nt' else 'clear')
    menu()

    customer_name = input("Please enter your name: ")
    filename = f"Tech_Computer_Solutions_Quote_{customer_name.replace(' ', '_')}.txt"

    # Open file for writing
    with open(filename, "w") as bill:
        bill.write("Tech Computer Solutions - Billing Quote\n")
        bill.write("=======================================================\n")
        bill.write(f"Customer Name: {customer_name}\n")
        bill.write("{:<15} {:<10} {:<15} {:<15}\n".format("Item", "Quantity", "Unit Price", "Total Price"))
        bill.write("=======================================================\n\n")

        total_amount = 0
        while True:
            item = input("Please enter the item to purchase: ").lower()
                
            if item not in computer_parts:
                print("Sorry, that item is not available today. Please choose from the available items.")
                continue
                
            try:
                quantity = int(input(f"How many {item}(s) would you like to purchase? "))
                if quantity <= 0:
                    print("Quantity must be a positive integer.")
                    continue
            except ValueError:
                print("Please enter a valid number for quantity.")
                continue
                
            unit_price = computer_parts[item]
            total_price = unit_price * quantity
            total_amount += total_price
                
            bill.write("{:<15} {:<10} ${:<14.2f} ${:<14.2f}\n".format(item, quantity, unit_price, total_price))
                
            more_items = input("Would you like to purchase another item? (Yes or No): ")
            if more_items.lower() != "yes":
                break
            
        # Calculate shipping and the grand total
        shipping = total_amount * 0.03
        grand_total = total_amount + shipping

        #prints Totals for text file
        bill.write("\n=======================================================\n")
        bill.write("{:<30} ${:<14.2f}\n".format("Subtotal", total_amount))
        bill.write("{:<30} ${:<14.2f}\n".format("Shipping (3%)", shipping))
        bill.write("{:<30} ${:<14.2f}\n".format("Total Amount Due", grand_total))
        bill.close()
    
    print(f"Quote created successfully! Please check the file '{filename}' for your quote.")
        
    more_customer = input("Are you a new customer or do you want to make another purchase? (Yes or No): ")
    if more_customer.lower() != "yes":
        break
    
print("Thank you for shopping at Tech Computer Solutions! Have a great day!")
time.sleep(3)
