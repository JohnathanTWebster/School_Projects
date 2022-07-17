#include <iostream>

using namespace std;

// Create new class for Banana Crates
class Banana_Crate
{
    // Public modifier to be accessed outside of class
public:
    // Properties
    int MAX_NUM_BANANAS = 5;   // Default banana max if none is delcared
    int numOfBananasTotal = 0; // Keeps current total of banans for crate
    int maxNumBananas = 0;     // If max count for crate is specified then assign to this value
    int bananaCountInBox = 0;  // Tracks the total in current crate

    // Default constructor
    Banana_Crate()
    {
        maxNumBananas = MAX_NUM_BANANAS;
    }
    // Override defult constructor
    Banana_Crate(int maxBananas)
    {
        maxNumBananas = maxBananas;
    }

    // Methods
    void addBanana()
    {
        // If the currnet banana count is more or equal to the max the crate can hold
        // create a new crate with the value of one and add to the total of bananas
        if (bananaCountInBox >= maxNumBananas)
        {
            bananaCountInBox = 1;
            numOfBananasTotal++;
        }
        // Otherwise add to both totals
        else
        {
            bananaCountInBox++;
            numOfBananasTotal++;
        }
    }
    // Display the current banana count in box and total
    void getCurrentBananaCount()
    {
        cout << "The number of bananas in the box is: " << bananaCountInBox << endl;
        cout << "The current number of bananas is: " << numOfBananasTotal << endl;
    }
    // Empty the crate but keep current count
    void emptyCrate()
    {
        bananaCountInBox = 0;
    }
};

int main()
{
    // Create two new instances of the crate class and override one with a new default max size
    Banana_Crate crate1;
    Banana_Crate crate2(3);

    // Add to crate 2
    crate2.addBanana();
    crate2.addBanana();
    crate2.addBanana();
    crate2.addBanana();
    crate2.addBanana();

    // Add to crate 1
    crate1.addBanana();
    crate1.addBanana();

    cout << "For create 1 " << endl;
    crate1.getCurrentBananaCount();

    cout << "For create 2 " << endl;
    crate2.getCurrentBananaCount();
}