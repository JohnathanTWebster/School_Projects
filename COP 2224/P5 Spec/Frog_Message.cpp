#include <iostream>

using namespace std;

// Create Frog class as parent
class FrogMessage
{

public:
    float priceOfMessage = 0.0;

    // Contructors
    FrogMessage() {}

    // Methods
    float getPriceOfMessage()
    {
        return priceOfMessage;
    }

    void setPriceOfMessage(float price)
    {
        priceOfMessage = price;
    }
};

// Create voicemessage class and inherit from Frogmessage class
class VoiceMessage : public FrogMessage
{
    float lengthInMinutes;

    const float COSTPERMINUTE = .11f;

public:
    // Contructors
    VoiceMessage() {}

    // Methods
    float getLengthOfVoiceMessage()

    {
        return priceOfMessage;
    }
    void setLengthOfVoiceMessage(float length)
    {
        lengthInMinutes = length;
        priceOfMessage = lengthInMinutes * COSTPERMINUTE;
        setPriceOfMessage(priceOfMessage);
    }
    void getPriceOfMessage()
    {
        cout << "Price of Voice message: $" << priceOfMessage << endl;
    }
};

// Create textmessage class and inherit from Frogmessage class
class TextMessage : public FrogMessage
{
    // Properties
    int numOfCharacters;

    const float COSTPERCHARACTER = .08f;

public:
    // Contructors
    TextMessage() {}

    // Methods
    float getLengthOfTextMessage()

    {
        return priceOfMessage;
    }
    void setLengthOfTextMessage(int length)
    {
        numOfCharacters = length;
        priceOfMessage = numOfCharacters * COSTPERCHARACTER;
        setPriceOfMessage(priceOfMessage);
    }
    void getPriceOfMessage()
    {
        cout << "Price of Text message: $" << priceOfMessage << endl;
    }
};

int main()
{
    // create new instances of objects
    VoiceMessage newVoicemessage;
    TextMessage newTextMessage;

    // assign specified values
    newVoicemessage.setLengthOfVoiceMessage(8);
    newTextMessage.setLengthOfTextMessage(12);
    newVoicemessage.getPriceOfMessage();
    newTextMessage.getPriceOfMessage();
}