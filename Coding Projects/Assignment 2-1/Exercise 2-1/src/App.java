import java.util.*;

public class App {

    public static void main(String[] args) throws Exception {
        
        Scanner input = new Scanner(System.in); //Get user input

        System.out.println("Enter an Celsius degree: "); //Prompt user to enter a celsius degree
        int celsius = input.nextInt();        

        System.out.println(celsius + " Celsius is: " + ConvertToFahrenheit(celsius) + " Fahrenheit");
        input.close();
    }


    public static double ConvertToFahrenheit(double num){
        
        double fahrenheit = (1.8 * num + 32); 
        return fahrenheit;
        
    }
}