import time, os

#Admission Program

#Loop variable
more = "y"

#Loop begins
while more.lower() == "y":

    #Greeting
    print ("\tWelcome to SCC Sports")
    print()

    #Display kiosk menu
    print ("****************************")
    print ("***** 1. SCC Studnet *******")
    print ("***** 2. SCC Alumni  *******")
    print ("***** 3. SCC Staff   *******")
    print ("***** 4. Other       *******")
    print ("****************************")
    print ()
    print ()


    #Ask user to enter a number
    choice = int(input("Please enter number: "))

    #Determine the price of admission
    if choice == 1:
        cost = 0
    elif choice == 2:
        cost = 2.50
    elif choice == 3:
        cost = 1
    else:
        cost = 5

    #Ask user if they want a Chaser Shirt.
    shirt = input("Would like to get a Chaser Shirt? (y or n): ")
    print()

    if shirt.lower() == "y":
        cost += 10

    #Display Total
    print(f"Please pay ${cost:.2f}")
    print()
    print()

    time.sleep(2)

    more = input("Do you want to buy another ticket? (y or n): ")


        
    #os.system ('cls')



    

