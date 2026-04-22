// Test Redo.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	//Display My Information 
	cout << "\t\t******************************" << endl;
	cout << "\t\t* Eric Maslyanchuk *" << endl;
	cout << "\t\t* CPT-168-A01S *" << endl;
	cout << "\t\t* Calculate Total Gross & Years Worked*" << endl;
	cout << "\t\t* Test Redo *" << endl;
	cout << "\t\t******************************" << endl << endl;

	//Declare Variables
	float grossPay = 0.0;
	int yearsWorked = 0;
	float baseWage = 0.0;
	int hoursWorked = 0;

	//Input
	cout << "How many years worked: ";
	cin >> yearsWorked;

	cout << "What is hourly rate: ";
	cin >> baseWage;


	//Decision
	if (yearsWorked < 2) {
		cout << "No Raise" << endl;

	}
	else if (yearsWorked <= 6)
	{
		grossPay = baseWage + 1.00;
	}
	else if (yearsWorked <= 10)
	{
		grossPay = baseWage + 2.00;
	}
	else
	{
		grossPay = baseWage + 3.50 ;
		
	}
	
	//OutPuy 
	if (yearsWorked > 1)
	{
		cout << "Gross Pay: $" << fixed << setprecision(2) << grossPay << endl;
	}
	
	//Input 
	cout << "How many hours worked this week: ";
	cin >> hoursWorked;

	
	//Decision 
	if (hoursWorked <= 40)
	{
		grossPay = baseWage * hoursWorked;
	}
	else
	{
		grossPay = (grossPay * 40) + (grossPay * 1.5 * (hoursWorked - 40));
	}

	//OutPuy 
	cout << "Gross Pay: $" << fixed << setprecision(2) << grossPay << endl;


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
