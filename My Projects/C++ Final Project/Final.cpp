// Final.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
	//reating a file
	//input - read in from this file 
	ifstream inFile;
	ofstream outFile;

	//open file PayRoll
	inFile.open("acres.txt", ios::in);
	outFile.open("report.txt", ios::app);

	//check if file open
	if (inFile.is_open() && outFile.is_open())
	{
		cout << "\t\t\t\t\t**********************" << endl;
		cout << "\t\t\t\t\t*  Eric Maslyanchuk  *" << endl;
		cout << "\t\t\t\t\t*  CPT - 168 - A01H  *" << endl;
		cout << "\t\t\t\t\t*       Final        *" << endl;
		cout << "\t\t\t\t\t**********************" << endl;
	}
	else
	{
		cout << "ERROR   FILE NOT OPEN" << endl;
	}

	// Declare Variables
	string firstName = "";
	string lastName = "";
	string state = "";
	string zipCode = "";
	string oddOrEven = "";
	string year = "";
	double acreAmount = 0.0;
	double tax = 0.0;
	int numRecord = 0;

	//printing header
	cout << "\n\tLast Name" << "\tFirst Initial" << "\tState" << "\tZip Code " << "\tAcres" << "\tTax" << "\t\tOdd / Even" << endl;
	cout << "\t_________" << "\t_____________" << "\t_____" << "\t_________" << "\t____" << "\t______" << "\t\t________\n" << endl;

	//reading file 
	while (inFile.eof() == false)
	{
		getline(inFile, firstName, '\#');
		getline(inFile, lastName, '\#');
		inFile >> acreAmount;
		inFile.ignore();
		getline(inFile, zipCode, '\#');
		inFile >> year;
		inFile.ignore();
		
		

		//calculations
		if (zipCode.substr(0, 1) == "9")
		{
			tax = acreAmount * 500.00;
			state = "CA";
		}
		else if (zipCode.substr(0, 1) == "2")
		{
			tax = acreAmount * 100;
			state = "SC";
		}
		else
		{
			tax = acreAmount * 200.00;
			state = "FL";
		}
		if (zipCode.length() <= 9)
		{
			zipCode.insert(5, "-8623");
		}
		if (year.substr(3) == "1" || year.substr(3) == "3" || year.substr(3) == "5" || year.substr(3) == "7" || year.substr(3) == "9")
		{
			oddOrEven = "Odd Year";
		}
		else
		{
			oddOrEven = "Even Year";
		}

		cout << "\t" << lastName << "     \t" << firstName[0] << ".\t\t" << state << "\t" << zipCode << "\t" << acreAmount << "\t$" << tax << ".00   \t" << oddOrEven << endl;

		numRecord++;

		outFile<< "\t" << lastName << "     \t" << firstName[0] << ".\t\t" << state << "\t" << zipCode << "\t" << acreAmount << "\t$" << tax << ".00   \t" << oddOrEven << endl;

		

	}

	//close file
	inFile.close();
	outFile.close();



	cout << "\n\n      Number of Records:  " << numRecord << endl;
	cout << "\t\t\t\t\***********************" << endl;
	cout << "\t\t\t\t\*  T H A N K  Y O U   *" << endl;
	cout << "\t\t\t\t\***********************" << endl;

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
