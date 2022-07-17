Design, code, and test a C++ class for a communication service called frogMessage. The class must include a field for the price of the message plus get and set methods for that field. Then, DERIVE two new classes from the frogMessage class. The first class must be called voiceMessage and the second class must be called textMessage. Include a default constructor for each class (you don't need any parameterized constructors).

The voiceMessage class must contain a float field for length of message in minutes, as well as get and set methods for that field. The set method must populate the price of the message based on the length of the message: 11 cents per minute (be sure to use a named constant for this).

The textMessage class must contain an int field for the number of characters in the message, as well as get and set methods for that field. The set method must populate the price of the message based on the length of the message: 8 cents per character (be sure to use a named constant for this).

Write a program that instantiates at least one object from each of the two derived classes. Include code and output  to demonstrate that your classes and all of the get/set methods are working properly.


[] Create class for FrogMessage
[] Create subclasses VoiceMessage & TextMessage
[] 