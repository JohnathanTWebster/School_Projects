//import java.util.*;
public class App {

  //  final private static Scanner ScannerObj = new Scanner(System.in); 
    

    

    public static void main(String[] args) throws Exception {
        Stock myStock = new Stock('$',"ORCL",34.5 );

        myStock.SetCurrentClosePrice(34.35);
        System.out.println(myStock.PercentageChange(myStock.GetPreviousPrice(), myStock.GetCurrentPrice()));
    }
}
