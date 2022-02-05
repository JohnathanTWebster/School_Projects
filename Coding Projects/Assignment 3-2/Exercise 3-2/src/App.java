import java.util.*;

public class App {

    //Globals that will store values
    static public double WEIGHT; 
    static public double FEET;
    static public double INCHES;
    static public double RESULT;
    static public double BMI;
    static Scanner scanner = new Scanner(System.in);


    public static void main(String[] args) throws Exception {
        
        convertToKilograms(getPounds()); //Gets weight in pounds from the user and converts to kilograms

        convertToInches(getFeet()); //Gets feet from user and converts to inches

        getInches(); //Gets inches

        INCHES = FEET + INCHES; //Add total inches together after converting FEET to inches

        convertToCentimeters(INCHES); //Converts total inches to centimeters

        calculateBMI(); //Converts collected values to a BMI number

        System.out.println("BMI is " + BMI); //Displays BMI to user

        System.out.println(checkRange()); //Checks range BMI falls in
        
    }

    public static String checkRange(){ //Checks range BMI falls in

        if (BMI < 18.5){

            return "Thinness";
        }

        else if (BMI < 25){

            return "Normal";
        }
         else if(BMI < 30){

            return "Overweight";

         }
         else{
             
         return "Obese";}
     }

    

    public static void calculateBMI(){ 

        BMI = (WEIGHT / INCHES / INCHES) * 10000;

    }
    
    public static double getPounds() {

        System.out.println("Enter weight in pounds: ");
        return WEIGHT = scanner.nextDouble();

    }

    public static double getFeet() {

        System.out.println("Enter feet: ");
        return FEET = scanner.nextDouble();

    }
    public static double getInches() {

        System.out.println("Enter inches: ");
        return INCHES = scanner.nextDouble();

    }
    public static double convertToKilograms(double pounds) {

        return WEIGHT = pounds / 2.2046226218;
        
    }
    
    public static double convertToInches(double feet){

        return FEET = feet * 12;
    }

    public static double convertToCentimeters(double inches){

        return INCHES = inches * 2.54;
    }  
}