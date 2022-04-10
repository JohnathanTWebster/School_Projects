#include <stdio.h>


float MILES, GALLONS, MPG;//Global variables for storage
float EMILES, EGALLONS, EMPG;

//Const for European values
const float LITERS = 3.785;
const float KILOMETERS = 1.609;



float convertMPG(float miles, float gallons){//Convert MPG value
    
    return MPG = miles/gallons;
}

float convertToEuropean(float miles, float gallons){//Convert the European values

    EMILES = miles * KILOMETERS;
    EGALLONS = gallons * LITERS;
    return EMPG = EMILES/EGALLONS;
}

int main(){

    printf("Please enter the number of miles traveled: ");//Ask user for miles
    scanf("%f", &MILES);
    printf("Please enter the number of gallons of gasoline consumed: ");//Ask user for gallons
    scanf("%f", &GALLONS);

    convertMPG(MILES, GALLONS);
    convertToEuropean(MILES, GALLONS);

    printf("The miles-per-gallon value is: %0.1f\n", MPG);
    printf("The liters-per-100km value is: %0.1f", EMPG);
    return 0;
}
