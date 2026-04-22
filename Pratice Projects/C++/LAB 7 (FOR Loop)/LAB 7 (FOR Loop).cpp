// LAB 7 (FOR Loop).cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

int main() //Main Function 
{
    //Declare Variables 
    char con = 'Y';
    int count = 0; //number counter
    int num = 0;
    double square = 0.0;
    double cube = 0.0;
    double fourth_power = 0.0;


    do {
        cout << "\t\t******************************" << endl;
        cout << "\t\t* Eric Maslyanchuk *" << endl;
        cout << "\t\t* CPT-168-A01S *" << endl;
        cout << "\t\t* Loop the Christmas Bonus  *" << endl;
        cout << "\t\t* Lab-7 *" << endl;
        cout << "\t\t******************************" << endl << endl;

        //Input
        cout << "Enter Number: " << endl;
        cin >> num; // Priming Read

        //Output 
        cout << "Number   Square    Cude     4Th Power: " << endl;
        cout << "______   ______    ____     _________" << endl;

        //Loop 
        for (int i = 0; i < 10; i++) {
            cout << setw(0) << num;
            cout << setw(10) << pow(num, 2.0);
            cout << setw(10) << pow(num, 3.0);
            cout << setw(14) << pow(num, 4.0) << endl;
            num +=5;
        }
        //Prompt to contiune 
        cout << "Would like to continue (Y or N)?" << endl;
        cin >> con;

        if (toupper(con) == 'Y')
        {
            system("cls");
        }
        else {

            (cout << "*********** T H A N K  Y O U ***********" << endl);
        }

    } while (toupper(con) == 'Y'); 


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
