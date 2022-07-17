#include <iostream>
#include <cmath>


using namespace std;

//declare static varables to be accessed throughout program
static int dollars, quarters, dimes, nickles, pennies;



int main(){

    //input storage
    double ammountDue;
    double ammountReceived;


   //prompt user and store value
   cout << "Please enter the ammount due: " << endl;
   cin >> ammountDue;
   cout << "Please enter the ammount received: " << endl;
   cin >> ammountReceived;

   //find the differece in change
   double changeDue = std::fmod(ammountReceived, ammountDue);

   //round off to 2nd decimal place
   changeDue = std::ceil(changeDue * 100.0) / 100.0;

   //find amount of dollars to return
   int dollars = std::fmod(ammountReceived, ammountDue);

   //update change left
   changeDue = std::fmod(changeDue, dollars);

   //find amount of quartes to return
   int quarters =  (changeDue* 100)/ 25;

   //update change left
   changeDue = (changeDue - ((quarters * 25) * .01));

   //find amount of dimes to return
   int dimes = (changeDue * 100) / 10;

   //update change left
   changeDue = changeDue - ((dimes * 10) * .01);

   //find amount of nickles to return if applicable
   if(changeDue >.04 && changeDue <.09){
       nickles = (changeDue * 100)/5;
       //update change left
       changeDue = changeDue - ((nickles * 5) * .01);
       //find amount of pennies to return
       pennies = (changeDue * 100);
   }
   else{

        //find amount of pennies to return
        pennies = (changeDue * 100) - (dimes * 10);
   }
   
   //display results
   cout << "Number of dollars due is: " << dollars << endl;
   cout << "Number of quarters due is: " << quarters << endl;
   cout << "Number of dimes due is: " << dimes << endl;
   cout << "Number of nickles due is: " << nickles << endl;
   cout << "Number of pennies due is: " << pennies;

}