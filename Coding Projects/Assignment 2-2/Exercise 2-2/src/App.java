import java.util.*;

public class App {
    //Declare our global variables 

    static int SubTotal; 
    static double GRate;
    static Scanner scanner = new Scanner(System.in); //Created global scanner due to scanner.close() issues
    public static void main(String[] args) throws Exception {
    
    getSubtotal();
    getGratuityRate();  
    
    System.out.println("Gratuity rate is $" + GRate + " and total is $" + (GRate + SubTotal));
    
        
    }

    public static int getSubtotal(){        

        System.out.println("Please enter the subtotal: ");

        int subTotal = scanner.nextInt();
        SubTotal = subTotal;
        
        return subTotal;
    }

    public static double getGratuityRate(){
        
        System.out.println("Please enter the gratuity rate: ");
        double gratuity = scanner.nextDouble();

        gratuity = gratuity * .1;
        
        scanner.close();
        GRate = gratuity;
        
        return gratuity;
    }
}
