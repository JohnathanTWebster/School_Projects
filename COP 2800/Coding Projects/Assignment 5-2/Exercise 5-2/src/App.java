public class App {

    
    public static void main(String[] args) throws Exception {
        
        double tuition = 10000;
        double newYearIncrease = 0;
        double increase = 0.05;
        double total = 0.0;

        System.out.println("If the tuition is: $" + Math.round(tuition) + " at a 5% rate");

        for(int x = 0; x < 10; x++){

            newYearIncrease = tuition * increase;
            tuition = tuition + newYearIncrease;
           
        }

        System.out.println("Then after 10 years the tuition will be: $" + Math.round(tuition));
        
        for(int x = 1; x <= 4; x++){

            newYearIncrease = tuition * increase;
            tuition = tuition + newYearIncrease;
            total = total + tuition;
            
        }
       
        System.out.println("So, if you choose to attend college for four years after ten then your total tuition will be: $" + Math.round(total));

    }
}
