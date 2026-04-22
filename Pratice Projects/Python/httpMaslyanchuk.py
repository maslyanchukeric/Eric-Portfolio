import time
import pyperclip  
import re       

# Define the regex pattern to match URLs starting with http://www or https://www

# The pattern is case-insensitive (re.IGNORECASE) to match uppercase or lowercase schemes
url_pattern = re.compile(r'https?://www\.[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}.*)', re.IGNORECASE)

# Get the text from the clipboard
clipboard_text = pyperclip.paste()

# Find all matches of the URL pattern in the clipboard content
matches = url_pattern.findall(clipboard_text)

# Check if there are any matches
if matches:
    # If matches are found, join them into a single string separated by new lines
    matched_urls = "\n".join(matches)
    
    # Print the matched URLs
    print("Copied to clipboard:")
    print(matched_urls)
    
    # Copy matched URLs back to the clipboard
    pyperclip.copy(matched_urls)
else:
    # If no matches are found, print an error message
    print("No web addresses found")


time.sleep(5)
