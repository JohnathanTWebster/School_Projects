


Design, implement, and test a C++ class that represents a crate that stores bananas.


Your class must provide members for maximum number of bananas and current number of bananas (for example, a crate having a maximum number of bananas of 5 can hold only 5 bananas -- when the crate has 5 bananas and an attempt is made to add another banana then the box must empty itself (reset number of bananas to 0) before adding the new banana).

The class must have a default constructor--the default constructor will use a NAMED CONSTANT to set the maximum banana items member to the default value of 5. You must have a second constructor that allows the user to choose a maximum banana count other than the default (this maximum banana count should be a parameter to the constructor). Your class must also include the following member methods: add a banana, get current banana count, and empty crate.

Use your new class in a small program that creates at least two crate objects (one with the default constructor and one with the second constructor) and calls their member methods such that the methods are demonstrated properly (for example, create a crate object with maximum size of 5, then call your add banana method 3 times, then call the get banana count method to ensure that the class is working properly.)

Turn in output showing that your program methods do what they're supposed to do (I recommend putting output statements in your main program interspersed with the calls to your object methods. By tracing those statements, and comparing the value returned by your get banana count method, you can ensure that things are working properly.

Be sure to use only named constants for all constants in the program.

Be sure to comment your code.


**Tasks

[] Create BananaCrate class
[] Add Properties:
    -Max_NUM_BANANAS
    -numOfBananas

[] Add Contructors:
    -One with override that specifies max number of bananas

[] Add Methods:
    -addBanana
    -getCurrentBananaCount
    -emptyCrate

