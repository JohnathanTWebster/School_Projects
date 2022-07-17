#include <iostream>


using namespace std;

int main(){

    string Name; //Input container

    cout << "What is your name? " << endl; //Ask user what their name is
    cin >> Name; //Store entered value at varable location
    cout << "Nice to meet you " + Name << endl; //Print name with message
    return 0;
    
}