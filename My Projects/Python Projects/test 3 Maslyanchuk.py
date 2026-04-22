import time
import os


def menu() :
    print("Welcome to Tech Computer Solutions !")
    print("Item             Price ")
    print("=======================")
    print("Graphics Card    $999.99")
    print("Processor        $549.99")
    print("Solid State      $149.99")
    print("Memory           $89.99")
    print("Motherboard      $349.99")
    print("Power Supply     $149.99")
    print("=======================")
    print()

#dictonary
computer_part = {
    'Graphics Card':999.99,
     'Processor':549.99,
     'Solid State':149.99,
     'Memory':89.99,
     'Motherboard':349.99,
     'Power Supply':149
    }

#Main Program function
def main():

    menu()
    customer_counter = 0

    #Program ask user if they are new customer
    more_customer = "Yes"
    """more_customer = input("Are you a New Customer? (Yes or No): ")
    #if more_customer.upper() != "Yes":
        #os.system('cls')"""

    customer_counter += 1

    while more_customer.upper() == "Yes":
        #Open file for writing
        with open("Tech Computer Solutions.txt", "w")as bill:
            bill.write("\t\t\tTech Computer Solution - Billing Quote\n")
            bill.write("\t\t=========================================\n")
            bill.write("{:<15} {:<10} {:<15} {:<15}\n".format("Item", "Quantity", "Unit Price", "Total Price"))
            bill.write("\t\t=========================================\n\n")

            total = 0

            purchase = "Yes"
            #user is asked if they want to buy an item
            while purchase.upper() == "Yes":
                item = input("Please enter item to purchase: ")

                if item not in computer_part:
                    print("Sorry, that item is not available today. Please choose from the available items.")
                    continue
                print()

            #program askes user the quantity and sjipping of comupter parts
            qty = int(input(f"How many {item}s would you like to purchase?"))
            price = computer_part[item] * qty
            total += price
            shipping = total_amount * 0.03
            file.write("{:<15} {:<10} ${:<14.2f} ${:<14.2f}\n".format(item, quantity, unit_price, total_price))

            #program writes item and prices on file
            bill.write("=========================================\n")
            bill.write("{:<30} ${:<14.2f}\n".format("Subtotal", total_amount))
            bill.write("{:<30} ${:<14.2f}\n".format("Shipping (3%)", shipping))
            bill.write("{:<30} ${:<14.2f}\n".format("Total Amount Due", grand_total))


            print("Quote created successfully. Check 'Tech Computer Solutions.txt' for the bill of sale.")

            more_customer = input("Are you a new/same cusotmer and want to make another purchase? (Yes or No): ?")
            
        

        
    print("Thank you for shopping at Teach Computer Solutions! Have a great day!")

    # Adding a delay before closing the program
    time.sleep(5)

if __name__ == "__main__":
    main()

        

            
                
                    

    
    
