import time
import os



#Function 1
def menu() :
    print("Welcome to Trift Store!")
    print("Item             Price ")
    print("=======================")
    print("Car Seat          5.00 ")
    print("Stroller          7.50 ")
    print("Push Toy          2.50 ")
    print("High Chair        5.00 ")
    print("Swing             6.00 ")
    print("PlayPen           5.50 ")
    print("=======================")
    
    

#system changing directory 
 #os.chdir('C:\\Users\\masly\\OneDrive\\Desktop\\School\\Semester 3\\CPT 180\\Tests')

# Dictionary of store items with prices
store_items = {
    'Car Seat': 5.00,
    'Stroller': 7.50,
    'Push Toy': 2.50,
    'High Chair': 5.00,
    'Swing': 6.00,
    'Playpen': 5.50
}

# Main program Function
def main():
    customer_counter = 0
    
    more_customer = "Yes"
    
    menu()

    #Program askes user if they are a new customer
    more_customer = input("Are you a new customer? (Yes or No): ")
    if more_customer.upper() != "YES":
        os.system('cls')
    
    customer_counter +=1 
    
    while more_customer.upper() == "YES":
    
        print()
        
        # Open file for writing (using 'with' ensures it closes automatically)
        with open("Thrift_Store_Bill.txt", "w") as bill:
            bill.write("\t\t\tThrift Store - Bill of Sale\n")
            bill.write("\t\t=========================================\n\n")
            bill.write("\t\tItem\t\t\tPrice\n\n")
            
            total = 0
            
            purchase = "Yes"

            #user asked if they want to purchase a item
            while purchase.upper() == "YES":
                item = input("Please enter the item to purchase: ")
                
                if item not in store_items:
                    print("Sorry, that item is not available today. Please choose from the available items.")
                    continue
                print()
                
                qty = int(input(f"How many {item}s would you like to purchase? "))
                price = store_items[item] * qty
                total += price
                
                #program writes item and price on file 
                bill.write(f"\t\t{item}\t\t\t${price:.2f}\n")
                bill.write(f"\n\t\tNumber of items: {qty}")
                
                purchase = input("Do you wish to purchase another item? (Yes or No): ")
                
            # Calculate tax and total amount due
            subtotal = total
            tax = subtotal * 0.07
            total_amount = subtotal + tax

            #program writes subtotal, tax, and total on file
            bill.write("\n")
            bill.write(f"\t\t\t\t\tSubtotal: ${subtotal:.2f}\n")
            bill.write(f"\t\t\t\t\tTax: ${tax:.2f}\n")
            bill.write("\t\t=========================================\n\n")
            bill.write(f"\t\t\t\t\tTotal Amount Due: ${total_amount:.2f}\n")
        
            print("Invoice created successfully. Check 'Thrift_Store_Bill.txt' for the bill of sale.")
        
        
            more_customer = input("Are you a new/same cusotmer and want to make another purchase? (Yes or No): ?")
            if more_customer.upper() != "Yes":
                continue
            
            

    
    print("Thank you for shopping at Thrift Store! Have a great day!")

    # Adding a delay before closing the program
    time.sleep(5)

if __name__ == "__main__":
    main()
        
                        

    
    
