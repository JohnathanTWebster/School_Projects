#include <stdio.h>


/*Write a C program that requests the user to enter a Fahrenheit temperature.
 The program should read the temperature as a type double number and pass it as an argument to a user-supplied function called Temperatures(). 
*/


double value; // Declare varable to take input for storage

double Tempratures(double fahrenheit){// Function that will do all the temprature conversion

    const double Fahrenheit = fahrenheit;//store original value
    const double Celsius = 5.0/9.0 * (fahrenheit - 32.0);//convert to celsius
    const double Kelvin = Celsius + 273.16;//convert to kelvin


    printf("%0.2lf degrees farenheit is \n%0.2lf degrees in celsius and \n%0.2lf degrees in Kelvin ", Fahrenheit , Celsius, Kelvin);/*
    print the message with the converted values and then break out of the function
    */
}

int main (){

    char QUIT = 'y';//set loop control varable
    
    while (QUIT == 'y'){//while true ask the user for input

        printf("Please enter a temprature in farenheit: ");//ask for input
        scanf("%lf", &value);//store input in value container
        Tempratures(value);//pass value as an arguemnt to the tempratures function
        printf("\nWould you like to enter another value? y = yes q = quit: ");//after function complets ask user if they would like to continue        
        scanf(" %c", &QUIT);//store entered value in the quit container

    }
    printf("Thank you for playing!");//after quiting display thank you message

    return 0;
}