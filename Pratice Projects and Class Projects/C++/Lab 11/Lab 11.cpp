// Lab 11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>

using namespace std;

//functions 
string collectInfo();

int main()
{		//creating file 
	ofstream outFile;

	//open file
	outFile.open("Empolyee Info.txt", ios::app);

	//check if file is open
	if (outFile.is_open())
	{
		
		cout << "File is open" << endl;

	}
	else
	{
		cout << "ERROR File not Open" << endl;
	}
	
	
	// Declare Variables
	string firstName;
	string lastName;
	string phoneNumber;
	string socialSecurity;
	string fullName;
	string  filestring;
	fullName = firstName + " " + lastName;
	char choice;

	//DisPlay Info
	cout << "\t\t*****************************" << endl;
	cout << "\t\t*      Eric Maslyanchuk     *" << endl;
	cout << "\t\t*          CPT 168          *" << endl;
	cout << "\t\t*          Lab 11           *" << endl;
	cout << "\t\t*****************************" << endl;

	// Process main loop
	do {
		 filestring = collectInfo();


		//output 
		outFile << filestring << endl;


		cout << "\nWould you like to try another set of phone and ssn (Y or N): ";
		cin >> choice;

		

	} while (toupper(choice) == 'Y');
	//cloes file
	outFile.close();

	cout << "\n\n\T H A N K  Y O U!\n\n";

	system("pause");
	return 0;
}
//Fuction definition
string collectInfo()
{
	string firstName;
	string lastName;
	string phoneNumber;
	string socialSecurity;
	string output;

	cout << "\nEnter First Name :";
	cin >> firstName;

	cout << "\nEnter Last Name :";
	cin >> lastName;


	//Nested loop 1
	do {
		cout << "\nEnter Phone Number (NO DASHES AND PARENTHESIS) :";
		cin >> phoneNumber;
	} while (phoneNumber.length() != 10);


	//Nested loop 2
	do {
		cout << "\nEnter Social Security Number (NO DASHES AND PARENTHESIS) :";
		cin >> socialSecurity;
	} while (socialSecurity.length() != 9);

	output= firstName + '#' + lastName +'#' +phoneNumber  +"#" +socialSecurity;
	return output;
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
