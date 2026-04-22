// Lab 4 Auto Sales Commission Eric Maslyanchuk CPT168.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
	// Display my information
	cout << "\t\t******************************" << endl;
	cout << "\t\t* Eric Maslyanchuk *" << endl;
	cout << "\t\t* CPT-168-A01S *" << endl;
	cout << "\t\t* Calculate Auto Sales Commission *" << endl;
	cout << "\t\t* Lab-3 *" << endl;
	cout << "\t\t******************************" << endl << endl;

	//Declare Variables
	int carsSold = 0;
	double commissoionAmount = 500;
	double totalCommission = 0.0;

	cout << "\nPlease enter number of cars you sold: ";
	cin >> carsSold;

	//Proccess
	totalCommission = carsSold * commissoionAmount;

	cout << "\nYour commision is: $" << totalComission;
	cout << "\n*********** T H A N K  Y O U ***********\n";
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
