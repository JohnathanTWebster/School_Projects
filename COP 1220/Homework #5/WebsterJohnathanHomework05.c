// Write a program that reads integers until 0 is entered. After input
// terminates, the program should report the total number of even integers
// (excluding the 0) entered, the average value of the even integers, the total
// number of odd integers entered, and the average value of the odd integers.

#include <stdio.h>
#include <ctype.h>

#define STOP 0 //Exit condition

int main(void) {

	int evenCount, evenSum, oddCount, oddSum = 0;//Value storage containers

	float evenAvg, oddAvg;//Value storage containers

	int input;//Storage for users entered value

	printf("Enter integers (0 to stop):\n");//Display message to enter values

	while(scanf("%d", &input) == 1 && input != STOP) { //Continue to ask for input until the user enters the exit condition
	
		if (input % 2 == 0) {//If the number is even
		
			evenCount++;//Increase the even count
			evenSum += input;//Add the even number entered to the total value of even numbers
		}
		else {//If the number is odd
		
			oddCount++;//Increase the odd count
			oddSum += input;//Add the odd number entered to the total odd value
		}
	}

	evenAvg = evenSum / (float) evenCount;//Find the average of even numbers
	oddAvg = oddSum / (float) oddCount;//Fine the average of odd numbers

	printf("Number of even integers: %d\n", evenCount);//Display even count
	printf("Average value of even integers: %.2f\n", evenAvg);//Display the average value of even numbers
	printf("Number of odd integers: %d\n", oddCount);//Display odd count
	printf("Average value of odd integers: %.2f\n", oddAvg);//Display the average number of odd numbers

	return 0;
}