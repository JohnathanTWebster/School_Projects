
Technical Requirements

An int[] data field named elements that stores the int values in the queue.
A data field named size that stores the number of elements in the queue.
A constructor that creates a Queue object with default capacity 8.
The method enqueue(int v) that adds v into the queue.
The method dequeue() that removes and returns the element from the queue.
The method empty() that returns true if the queue is empty.
The method getSize() that returns the size of the queue.

Outcome

Implement the class with the initial array size set to 8.
The array size will be doubled once the number of the elements exceeds the size.
After an element is removed from the beginning of the array, you need to shift all elements in the array one position the left.
Write a test program that adds 20 numbers from 1 to 20 into the queue and removes these numbers and displays them.