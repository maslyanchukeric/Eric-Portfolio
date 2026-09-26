// Lab 5 Calculate the Christmas Bonus.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    //Display My Information 
	cout << "\t\t******************************" << endl;
	cout << "\t\t* Eric Maslyanchuk *" << endl;
	cout << "\t\t* CPT-168-A01S *" << endl;
	cout << "\t\t* Calculate the Christmas Bonus  *" << endl;
	cout << "\t\t* Lab-5 *" << endl;
	cout << "\t\t******************************" << endl << endl;

	//Declare Variables 
	float grossPay = 0.0;
	int yearsWorked = 0;
	float bonusPay = 0.0;

	//Input 
	cout << "\Please enter your gross pay per year :";
	cin >> grossPay;

	//Input 
	cout << "\Pleas enter nunber of years worked :";
	cin >> yearsWorked;

	//Decision
	{if (yearsWorked < 1)
		cout << "\Not eligible for Christmas Bonus" << endl;
	else
	{
		if (yearsWorked > 5)
			bonusPay = grossPay * .02;
		else
			bonusPay = grossPay * .01;
		cout << "\Christmas Bonus: $ " << bonusPay;
	}
	
	}
	
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
