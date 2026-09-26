// CPT 168 Eric Maslyanchuk Test 2.cpp : This file contains the 'main' function. Program execution begins and ends there.
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
	cout << "\t\t* Calculate Package Weight*" << endl;
	cout << "\t\t* Test 2 *" << endl;
	cout << "\t\t******************************" << endl << endl;

	//Declare Variables
	float shippingCost = 0.0;
	int weight = 0;

	//Input
	cout << " Enter packeage weight: "; 
	cin >> weight;

	//Decision
	if (weight < 8) {
		cout << "Free Shipping: " << endl;
	} 
	else if (weight <= 24)
	{
		shippingCost = weight * .20;
	}
	else if (weight <= 50)
	{
		shippingCost = weight * .30;
	}
	else
	{
		shippingCost = 100;
	}

	cout << "Shipping Cost: $" << fixed << setprecision(2) << shippingCost << endl;
	cout << "Thank You!" endl;
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
