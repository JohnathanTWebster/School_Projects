import java.util.ArrayList;
import java.util.*;

public class App {
    public static void main(String[] args) throws Exception {

        Scanner myScanner = new Scanner(System.in);
        ArrayList<Integer> myList = new ArrayList<>();

        System.out.print("Enter 10 integers: ");
		for (int i = 0; i < 10; i++) {
			myList.add(myScanner.nextInt());
		}
	
		

		// Display the distinct integers
		System.out.print("The distinct integers are ");
		
        // Invoke removeDuplicate method
		System.out.println(removeDuplicateIntegers(myList));


    }

    public static <Test> ArrayList<Test> removeDuplicateIntegers(ArrayList<Test> sampleList){

        ArrayList<Test> newList = new ArrayList<Test>();

        for(Test element : sampleList){

            if(!newList.contains(element)){
                newList.add(element);
            }
        }
        return newList;
        
    }
}
