/*
Write a program that shows you a menu offering you the choice of addition, subtraction, multiplication, or division.
After getting your choice, the program asks for two numbers, then performs the requested operation.
The program should accept only the offered menu choices.
It should use type float for the numbers and allow the user to try again if he or she fails to enter a number. 
In the case of division, the program should prompt the user to enter a new value if 0 is entered as the value for the second number. 
*/




#include <stdio.h>
#include <ctype.h>

int getFirst(void);
void welcomMenu(void);
float getNumbers(void);

int main(void)
{
	int operation;
	float num1, num2;

	welcomMenu();//display the menu to the user and get the values entered
	while ((operation = getFirst()) != 'q')//while not quit
	{
		printf("Enter first number: ");//get first number
		num1 = getNumbers();
		printf("Enter second number: ");//get second number
		num2 = getNumbers();

		switch (operation)//uses the correct function for the provided operation
		{
			case ('a') :
				printf("%.3f + %.3f = %.3f\n", num1, num2, num1 + num2);
				break;
			case ('s') :
				printf("%.3f - %.3f = %.3f\n", num1, num2, num1 - num2);
				break;
			case ('m') :
				printf("%.3f * %.3f = %.3f\n", num1, num2, num1 * num2);
				break;
			case ('d') :
				while (num2 == 0)
				{
					printf("Enter a number other than 0: ");
					num2 = getNumbers();
				}
				printf("%.3f / %.3f = %.3f\n", num1, num2, num1 / num2);
				break;
			default :
				printf("I do not recognize that input. Try again.");
		}
		welcomMenu();
	}


}

int getFirst(void)
{
	// return first non-whitespace character
	int ch;

	do ch = getchar(); while (isspace(ch));

	while (getchar() != '\n')
		;

	return ch;
}


void welcomMenu(void)
{
	printf("Enter the operation of your choice:\n");
	printf("a. add            s. subtract\n");
	printf("m. multiply       d. divide\n");
	printf("q. quit\n");
}

float getNumbers(void)
{
	int ch;
	float num;

	while (scanf("%f", &num) != 1)
	{
		while ((ch = getchar()) != '\n') // echo user input and clear stream
			putchar(ch);

		printf(" is not a number.\n");
		printf("Please enter a number, such as 2.5, -1.78E8, or 3: ");

       
	}

	return num;
}