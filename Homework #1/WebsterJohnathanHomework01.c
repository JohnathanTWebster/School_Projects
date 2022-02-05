#include <stdio.h>

//Write a C program that 
//requests a volume in cups and that displays the equivalent volumes in 
//pints, ounces, tablespoons, and teaspoons.

float CUPS, PINTS, OUNCES, TABLESPOONS, TEASPOONS = 0.0;

float convertToPints(int cups){ //Converts cups to pints
   return PINTS = cups * 0.5; 
}

float convertToOunces(int cups){ //Converts cups to ounces
   return OUNCES = cups * 8; 
}

float convertToTablespoons(int cups){ //Converts cups to tablespoons
   return TABLESPOONS = cups * 16; 
}

float convertToTeaspoons(int cups){ //Converts cups to teaspoons
   return TEASPOONS = cups * 48; 
}

int converterStorage(){ //Stores all the functions that perform the operations

    convertToPints(CUPS);
    convertToOunces(CUPS);
    convertToTablespoons(CUPS);
    convertToTeaspoons(CUPS);
}

int main() {

    printf("Please enter a value in cups: "); //Prompts user for input
    scanf("%f", &CUPS); //Stores value as a float
    converterStorage(); //Calls all the functions that perform the operations

    printf("%0.2f cups is: %0.2f in pints, %0.2f in ounces, %0.2f in tablespoons, and %0.2f in teaspoons."
    , CUPS, PINTS, OUNCES, TABLESPOONS, TEASPOONS); //Displays message to user
}