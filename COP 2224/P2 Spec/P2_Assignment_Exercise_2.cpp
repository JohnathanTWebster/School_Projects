#include <iostream>

/*
Design, code, and test a C++ application that allows a user to enter integers continuously
until the value 70 is entered. Once the application has finished getting numbers from the user, 
output the number of numbers that were entered, the sum of those numbers, the average of those
numbers, the largest value entered, and the smallest number entered. Note that 70 is the 
sentinel value and it is NOT part of the data. Submit output showing at least seven input values.
Note that you cannot use an integer for your average (averages must have a fractional component)
The sentinel value must be stored as a named constant, NOT as a magic number.
*/

using namespace std;

int main(){

    //global varables    
    int input;
    int QUIT;
    static int numbersEntered;
    static int sumOfNumbers;
    static double averageOfNumbers;
    static int largetsNumber, smallestNumber;
    
    //prompt the user to enter numbers until QUIT is entered

    cout << "Please enter numbers followed by the ENTER key. To exit enter the number 70:";
    cin >> input;
    largetsNumber = input;
    smallestNumber = input;
    QUIT = input;
    while(QUIT != 70){

        if(largetsNumber < QUIT){
            largetsNumber = QUIT;
        }else if(smallestNumber > QUIT){
            smallestNumber = QUIT;
        }
        numbersEntered++;
        sumOfNumbers = sumOfNumbers + QUIT;
        cout << "Enter another number or QUIT: ";
        cin >> QUIT;
    }

    averageOfNumbers = (double)sumOfNumbers / (double)numbersEntered;

    cout << "Total numbers entered: " << numbersEntered << endl;
    cout << "Sum of numbers entered: " << sumOfNumbers << endl;
    cout << "Average of numbers entered: " << averageOfNumbers << endl;
    cout << "Largest of numbers entered: " << largetsNumber << endl;
    cout << "Smallest of numbers entered: " << smallestNumber << endl;
    


}