public class App {
    public static void main(String[] args) throws Exception {

        Queue queue = new Queue();
        // inserting 20 numbers into queue
        for (int item = 1; item <= 20; item++) {
            queue.enqueue(item);
        }

        // displaying 20 numbers first in first out basis
        for (int i = 0; i < 20; i++) {
            System.out.printf("%2d ", queue.dequeue());
            if ((i + 1) % 5 == 0) System.out.printf("\n");
        }
    }
    
}
