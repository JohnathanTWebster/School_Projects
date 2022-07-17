public class App {
    public static void main(String[] args) throws CloneNotSupportedException {
        // Create a MyStack object
        MyStack stack1 = new MyStack();

        // Push objects on to stack1
        System.out.println("Pushing the number 4, 5, and 6 to 1st stack...");
        stack1.push(4);
        stack1.push(5);
        stack1.push(6);

        // Clone stack1 and assign the clone to stack2
        System.out.println("Cloning 1st stack...");
        MyStack stack2 = (MyStack) stack1.clone();

        // Pop an object from stack1
        System.out.println("Popping object from 1st stack...");
        stack1.pop();

        // Display results
        System.out.print("1st ");
        System.out.println(stack1);
        System.out.print("2nd ");
        System.out.println(stack2);
        System.out.println("Is the 1st stack equal to the 2nd? " +
                (stack1 == stack2));
    }
}
