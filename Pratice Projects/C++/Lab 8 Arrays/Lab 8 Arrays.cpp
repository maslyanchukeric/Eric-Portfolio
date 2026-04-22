// Lab 8 Arrays.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

using namespace std;

int main()
{
    system("color b0");

    //Delcare Variables 
    int userNum = 0;
    string actor[6]{"Angelina Jolie", "Brad Pitt", "Margot Robbie", "George Clooney", "Jennifer Lopez", "Jennifer Lawrence"};
    string actorNumber[6]{ "949-232-1124","949-865-3492", "864-235-7569", "939-453-2288", "987-209-2132", "543 - 239 - 8745"};
    char answer = ' ';

    //loop
    do{
        system("cls");
        cout << "\t\t******************************" << endl;
        cout << "\t\t* Eric Maslyanchuk *" << endl;
        cout << "\t\t* CPT-168-A01S *" << endl;
        cout << "\t\t* Loop the Christmas Bonus  *" << endl;
        cout << "\t\t* Lab-6 *" << endl;
        cout << "\t\t******************************" << endl << endl;

        cout << "Please Enter a number from 1-6: ";
        cin >> userNum;

        if (userNum > 0 && userNum <= 6) {
            cout << "Actors Name: " << actor[userNum - 1] << endl;
                
            cout << "Actors Number:" << actorNumber[userNum - 1] << endl;
        }
        else {
            cout << "Invaild Number" << endl;
        }
        //Prompt to continue 
        cout << "Would you like to continue (Y or N)";
        cin >> answer;


    } while (toupper(answer) == 'Y');
    (cout << "*********** T H A N K  Y O U ***********" << endl);
    
    system("pause");
    return (0);
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
