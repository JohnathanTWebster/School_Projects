public class Queue {

    //Properties
    private int[] elements;
    private int size;
    private int capacity;

    //Methods

    Queue(int capacity){
        this.capacity = capacity;
        this.elements = new int[capacity];
    }

    public Queue(){
        this(8);
    }
    
    public void enqueue(int addNum){
        if (this.size >= this.elements.length){
            int[] temp = new int[this.size * 2];
            System.arraycopy(this.elements, 0, temp, 0, this.size);
            this.elements = temp;
        }
        this.elements[size++] = addNum;
    }

    public int dequeue(){
        int remvNum = this.elements[0];
        this.size--;

        //assignes a loop control var of 0 to loop through array
        //then assignes the element at the next index location to the current index
        for (int items = 0; items < size; items++){
            this.elements[items] = this.elements[items + 1];
        } 
        return remvNum;
    }
    
    public boolean isEmpty(){
        return this.size == 0;
    }
   


    //Getters and Setters

    public int getSize(){
        return this.size;
    }
    public int getCapacity(){
        return this.capacity;
    }
    

}