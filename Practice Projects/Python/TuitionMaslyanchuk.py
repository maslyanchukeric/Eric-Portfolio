import time

#User enter Name
print (' What is your Name? ')
input ()

#Users enters the amount of credit taken
print (' How many class are you taking this semester? : ')
credit = input ()


#Calculate Tuition
amt = int(credit) * 198

#display total tuition
print (' This is your total Tuition amount ' + format(amt, ',.2f'))

#Print Thank you
print (' THANK YOU ')

#time for program to run
time.sleep(5)
