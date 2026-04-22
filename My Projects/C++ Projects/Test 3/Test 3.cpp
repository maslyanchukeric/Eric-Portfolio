// Test 3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include <iostream>

#include <iomanip>

using namespace std;

int main()
{
    system("color b0");

    //Delcare Variables 
    int num = 0;
    string horoscope[8]{ "This week is going to be a lucky week for you, buy lotto", "You will barely escape an accident this week","You are going to have a week full of surprises", "You will receive a large amount of money this week", "You will get promoted at your job this week", "You will get a phone call from an old friend this week", "You may have some type of car problem this week", "Today is a day of fun"};
    string weekDay[8]{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Funday"};
    string carolinaNum[8]{ "8,9,23,29,50", "7,19,21,38,51", "6,25,28,30,49", "22,27,33,37,42", "16,18,28,34,38", "10,3,6,13,33", "7,21,25,28,37", "15,10,20,33,66"};
    
    //Displying Info

    cout << "\t\t******************************" << endl;
    cout << "\t\t* Eric Maslyanchuk *" << endl;
    cout << "\t\t* CPT-168-A01S *" << endl;
    cout << "\t\t* Loop the Christmas Bonus  *" << endl;
    cout << "\t\t* Test 3 *" << endl;
    cout << "\t\t******************************" << endl << endl;

    cout << "\n\n\t\t<<<<<<<<<<<<<<Hello>>>>>>>>>>>>>>";

   //loop

    do {
        //input
        cout << "\n\n\tEnter number from 1-7 or to exit 99 :";
        cin >> num;

        //Process or Decision

        if (num > 0 && num < 8) {

            cout << "\n\tYour " << weekDay[num - 1] << " Horoscope: " << horoscope[num - 1] << endl;
            cout << "\tLucky Carolina5 numbers: " << carolinaNum[num - 1] << endl;
        }
        else {

            cout << "\tInvalid Number was entered" << endl;
            cout << "\n\n\tEnter number from 1-7 or to exit 99 :";
            cin >> num;

        }
    } while (num != 99);
    
    //Output
    
    (cout << "*********** T H A N K  Y O U ***********" << endl);
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
