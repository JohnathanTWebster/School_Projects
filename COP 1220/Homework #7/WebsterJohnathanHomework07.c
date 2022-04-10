#include <stdio.h>

/*
Write a function that takes three arguments: a character and two integers. The character is to be printed.
The first integer specifies the number of times that the character is to be printed on a line, 
and the second integer specifies the number of lines that are to be printed.
Write a program that makes use of this function.
*/

const int numPrintedOnLine, numRows;//storage for entered values
const char character;//storage for chosen character


void printLines(char sCharacter, int printedOnLine, int rows){//takes three arguments, character, how many to print on one line, and how many rows

    for(int x = 0; x < rows; x++){//loop for how many rows

        for(int y = 0; y < printedOnLine; y++){//loop for how many times to print the character
            printf("%c", sCharacter);
        }

        printf("\n");//at the end of the character loop start a new line

    }

}

int main(){

    printf("Please enter a Character, the number of times you want the character to be printed, and the number of rows: ");
    scanf("%c %d %d", &character, &numPrintedOnLine, &numRows);
    printLines(character, numPrintedOnLine,numRows);
    return 0;

}