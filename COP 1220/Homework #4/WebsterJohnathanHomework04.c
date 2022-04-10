#include <stdio.h>

/*Write a C program that requests lower and upper integer limits, calculates the sum of all the integer squares from the square of the lower limit to the square of the 
upper limit, and displays the answer. 
The program should then continue to prompt for limits and display answers until the user enters an upper limit that is equal to or less than the lower limit.*/


const int int1 , int2; //Declare globaL containers


int SumOfSquares(int num1, int num2){//Function that will perform the mathematical arrhythmic
    
    int loopControl = num1;//Controls the loop
    int squareSum = 0;//Place container for current square
    int total = 0;//Container for total

    for (loopControl; loopControl <= num2; loopControl++){//Loop to go though each number between the given

        squareSum = loopControl * loopControl;//Computes square
        total = squareSum + total;//Assigns total
    }

    return total;
}




int main(){

    printf("Please enter lower and upper integer limits: ");//Prompt the user to enter the limits seperated by a space
    scanf("%d %d", &int1, &int2 );//Store entered values


    while(int1 != int2){//Loop to continue entering values until the same value is entered twice
        printf("The sum of the squares from %d to %d is %d", (int1*int1), (int2*int2), SumOfSquares(int1, int2));
        //^^Print the message with the given numbers squared and the total between them
        printf("\nEnter the next set of limits: ");//Prompt user again
        scanf("%d %d", &int1, &int2 );//Assign again and start over if the values are not the same
    }
    printf("Done");

    return 0;
}
