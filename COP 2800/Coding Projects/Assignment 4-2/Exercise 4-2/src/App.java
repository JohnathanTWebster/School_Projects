import java.util.Scanner;


public class App {

    static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws Exception {

        System.out.println("Enter the side: ");//Prompt user

        double value = scanner.nextDouble();//Store value user enters

        System.out.printf("The area of a hexagon is: %.2f", computeArea(value));
        //Print to the console above message with the computed area

    }
    
    public static double computeArea(double x){//Take in a double value and formulate the area
        
        return x = (x * x) * 2.5980762113533159402911695122588;
        
    }
}
