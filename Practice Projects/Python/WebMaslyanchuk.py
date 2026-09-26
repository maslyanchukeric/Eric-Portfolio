#Program downloading SCC website and look for h1 heading
import time
import requests
import bs4

#Define url
url = ('https://www.sccsc.edu//admissions-aid/apply.php/')

try:
    #send a HTTP GET request to URL
    response = requests.get(url)

    #check if request is successful
    response.raise_for_status()
    
    #Parse content of web page with Beautiful Soup
    soup = bs4.BeautifulSoup(response.text, 'html.parser')

    #Extract heading from the website
    heading_elements = soup.select ('h1')

    #Display number of heading elements found
    print(f"Number of Heading elements found: {len(heading_elements)}")

    #Print text for each element
    for element in heading_elements:
        print(element.getText())

#if the url doesnt match error will be printed 
except Exception as ex:
    print("There was an error! Please try again.")

    

    
    


