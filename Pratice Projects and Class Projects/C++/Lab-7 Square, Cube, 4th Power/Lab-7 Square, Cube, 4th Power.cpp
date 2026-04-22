// Lab-7 Square, Cube, 4th Power.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

int main()
{
	//Display My Information 
	//"\t\t******************************" << endl;
	//"\t\t* Eric Maslyanchuk *" << endl;
	//"\t\t* CPT-168-A01S *" << endl;
	// "\t\t* Square, Cube, & 4th Power*" << endl;
	//"\t\t* Lab-7 *" << endl;
	//"\t\t******************************" << endl << endl;

	//Declare Variables
	double sqaure = 0.0;
	double cube = 0.0;
	double foruth_power = 0.0;

	int num = 0;
	char condition = ' ';
	int count = 0;//number counted

	do
	{
		cout << "\t\t******************************" << endl;
		cout << "\t\t* Eric Maslyanchuk *" << endl;
		cout << "\t\t* CPT-168-A01S *" << endl;
		cout << "\t\t* Loop the Christmas Bonus  *" << endl;
		cout << "\t\t* Lab-7 *" << endl;
		cout << "\t\t******************************" << endl << endl;

		//input 
		cout << "Enter Number: ";
		cin >> num;//priming 

		//Output
		cout << "Number  Square    Cube      4th Power: " << endl;
		cout << "______  ______    ____      _________" << endl;


		//Loop
		int count = 0;

		while (count < 10)

		{
			cout << setw(0) << num << setw(10) << pow(num, 2.0) << setw(10) << pow(num, 3.0) << setw(14) << pow(num, 4.0) << endl;
			num += 5;
			count++;
		}

			//Prompt to continue 
			cout << "Would you like to continue (Y or N)";
				cin >> condition;
			

			if (toupper (condition) == 'Y') 
			{
				system("cls");
			}
			else {

				(cout << "*********** T H A N K  Y O U ***********" << endl);
			}
		


	} while (toupper (condition) == 'Y');




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