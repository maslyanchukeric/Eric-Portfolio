// Lab 9 String Manipulation.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;
int main()
{
	// Declare Variables
	string firstName;
	string lastName;
	string phoneNumber;
	string socialSecurity;
	string fullName;
	fullName = firstName + " " + lastName;
	char choice;

	//DisPlay Info
	cout << "\t\t*****************************" << endl;
	cout << "\t\t*      Eric Maslyanchuk     *" << endl;
	cout << "\t\t*          CPT 168          *" << endl;
	cout << "\t\t*    String Manipulation    *" << endl;
	cout << "\t\t*****************************" << endl;

	// Process main loop

	do {
		cout << "\nEnter First Name :";
		cin >> firstName;

		cout << "\nEnter Last Name :";
		cin >> lastName;


		//Nested loop 1
		do {
			cout << "Enter Phone Number (NO DASHES AND PARENTHESIS) :";
			cin >> phoneNumber;
		} while (phoneNumber.length() != 10);


		//Nested loop 2
		do {
			cout << "Enter Social Security Number (NO DASHES AND PARENTHESIS) :";
			cin >> socialSecurity;
		} while (socialSecurity.length() != 9);

		fullName = firstName + " " + lastName;

		//Output
		cout << "\nYour Full Name is :" << fullName;
		cout << "\nYour Reversed Full Nmae is :";


		// Output Reverse Name
		for (int i = fullName.length(); i >= 0; i--) 
		{
			cout << fullName[i];
		}


		//Output Phone Number
		cout << "\nYour Phone Number: (" << phoneNumber.substr(0, 3) << ")" << phoneNumber.substr(3, 3) << "-" << phoneNumber.substr(6, 4) << endl;
		cout << "Your Social Security: " << socialSecurity.substr(0, 3) << "-" << socialSecurity.substr(3, 2) << "-" << socialSecurity.substr(5, 4) << endl;

		cout << "\nWould you like to try another set of phone and ssn (Y or N): ";
		cin >> choice;
		
	} while (toupper (choice) == 'Y');

	cout << "\n\n\T H A N K  Y O U!\n\n";

	system("pause");
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
