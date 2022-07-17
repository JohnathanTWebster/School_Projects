#include <iostream>
using namespace std;

//Global
int TESTCASE = 500;
int firstNumber, secondNumber;

//Methods 

void doTheyAddTo500(int firstInt, int secondInt){

    if(firstNumber + secondNumber == 500){//If the provided values add to 500 print true
        cout << "true";
    }else{
        cout<<"false";//else print false
    }
}

//Main
int main(){
    

cout << "Enter the first number:"<< endl;
cin >> firstNumber;
cout << "Enter the second number: "<< endl;
cin >> secondNumber;

doTheyAddTo500(firstNumber, secondNumber);


}