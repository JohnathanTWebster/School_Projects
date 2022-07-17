#include <iostream>

/*
Design, code, and test a C++ application that accepts two corner points (x, y coordinate pairs) 
of a rectangle from the user. The first point will be the lower-left corner and the second will 
be the upper-right corner. Use structured decision logic to determine whether the rectangle is 
a square, or is in "portrait" or "landscape" orientation. In this coordinate system you can assume
that the rectangle's coordinates are all positive.
Turn in input showing that your program correctly identified all three cases of rectangles.
*/
using namespace std;

int main(){

//global containers
int firstX, firstY;
int secondX, secondY;


//ask the user for input
cout << "Please enter the first x value: ";
cin >> firstX;
cout << "Please enter the first y value: ";
cin >> firstY;
cout << "Please enter the second x value: ";
cin >> secondX;
cout << "Please enter the second y value: ";
cin >> secondY;

//determine if the shape is in landscape, portrait, or is a square
if(firstX == firstY && secondX == secondY){
    cout << "The shape is a square.";
}else if (firstY > secondX)
{
    cout << "The shape is in portrait.";
}else{
    cout << "The shape is in landscape.";
}


}