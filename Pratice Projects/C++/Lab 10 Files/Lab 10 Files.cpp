// Lab 10 Files.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
    //Creating a file 
    //file object

    //input - read in from this file 
    ifstream inFile;

    //open file PayRoll
    inFile.open("PayRoll.txt", ios::in);

    //check if file open
    if(inFile.is_open())
    {
        cout << "\t\t\t\t\**********************" << endl;
        cout << "\t\t\t\t\*  Eric Maslyanchuk  *" << endl;
        cout << "\t\t\t\t\*  CPT - 168 - A01H  *" << endl;
        cout << "\t\t\t\t\*      lab 10        *" << endl;
        cout << "\t\t\t\t\**********************" << endl;
    }
    else
    {
        cout << "ERROR   FILE NOT OPEN" << endl;
    }

    //Declare Variables
    string ssn = "";
    string firstName = "";
    string lastName = "";
    double workHours = 0.0;
    double hourlyRate = 0.0;
    double grossPay = 0.0;
    double netPay = 0.0;
    double totalDeductions = 0.0;
    double totalNetPay = 0.0;
    double socialSecurity = 0.0;
    double retirement = 0.0;
    double federalTax = 0.0;
    int numRecord = 0;


    //print header out 
    cout << "\nSSN" << "\tName" << "\t\tHours" << "\tRate" << "\tGross" << "\tDeduction" << "\tNet Pay" << endl;
    cout << "\n____" << "\t____________" << "\t_____" << "\t_____" << "\t______" << "\t_________" << "\t_______" << endl;
    cout << fixed << setprecision(2);
    
    //read file
    while (inFile.eof() == false)
    {
        getline(inFile, firstName, '\#');
        getline(inFile, lastName, '\#');
        getline(inFile, ssn, '\#');
        inFile >> workHours;
        inFile.ignore();
        inFile >> hourlyRate;
        inFile.ignore();
        

        //calculate work hours
        if (workHours > 40)
        {
            grossPay = (40 * hourlyRate) + ((workHours - 40) * (hourlyRate * 1.5));
        }
        else
        {
            grossPay = hourlyRate * workHours;
        }

        //calculate deductions
        socialSecurity = 0.02 * grossPay;
        retirement = 0.05 * grossPay;
        federalTax = 0.03 * grossPay;
        totalDeductions = socialSecurity + retirement + federalTax;
        netPay = grossPay - totalDeductions;
        totalNetPay += netPay;

       cout << ssn.substr(ssn.length() - 4) << "\t" << firstName.substr(0, 1) << ".  " << lastName << "\t" << workHours << "\t" << hourlyRate << "\t" << grossPay << "\t" << totalDeductions << "\t\t" << netPay << endl;
       numRecord++;
    }

    //close file
    inFile.close();

   
  
    //output 
    cout << "\nNumber of records : " << numRecord << endl;
    cout << "Total net pay : " << totalNetPay << endl;
    cout << "\t\t\t\t\***********************" << endl;
    cout << "\t\t\t\t\*  T H A N K  Y O U   *" << endl;
    cout << "\t\t\t\t\***********************" << endl;

    system("pause");
    return 0;

    //could have done it this way instead of line 58
    //while(inFile.eof() == false)
    //getline(inFile, firstName, '\t)
    //getline(inFile, lastName, '\t)
    //getline(inFile, ssn, '\t)
    //inFile >> workHours
    //inFile.ignore
    //inFile >> hourlyRate
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
