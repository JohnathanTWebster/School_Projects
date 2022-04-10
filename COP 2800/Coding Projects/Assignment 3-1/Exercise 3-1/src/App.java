import java.util.*;
public class App {

    static int YEAR;
    static int INTMONTH;
    static String STRMONTH;
    static int DAYS;
    static Scanner scanner = new Scanner(System.in);


    public static void main(String[] args) throws Exception {
        
        getMonth();
        getYear();
        setYearAndDay();       

        System.out.println(STRMONTH +" "+ YEAR +" had "+ DAYS);
    }

     
    public static void setYearAndDay(){
        switch (INTMONTH){

            case 1: 
            STRMONTH = "January"; 
            DAYS = 31;
            break;

            case 2: 
            STRMONTH = "February";
            if (YEAR % 4 == 0){
                DAYS = 29;
            }else{
                DAYS = 28;
            }          
            break;

            case 3: 
            STRMONTH = "March";
            DAYS = 31;
            break;

            case 4:
            STRMONTH = "April";
            DAYS = 30;
            break;

            case 5:
            STRMONTH = "May";
            DAYS = 31;
            break;
            
            case 6:
            STRMONTH = "June";
            DAYS = 30;
            break;

            case 7:
            STRMONTH = "July";
            DAYS = 31;
            break;

            case 8:
            STRMONTH = "August";
            DAYS = 31;
            break;

            case 9:
            STRMONTH = "September";
            DAYS = 30;
            break;

            case 10:
            STRMONTH = "October";
            DAYS = 31;
            break;

            case 11:
            STRMONTH = "November";
            DAYS = 30;
            break;

            case 12:
            STRMONTH = "December";
            DAYS = 31;
            break;

        }


    }
    
    public static int getMonth(){

        System.out.println("Please enter a month in numerical format: ");
        return INTMONTH = scanner.nextInt();

    }

    public static int getYear(){

        System.out.println("Please enter a year: ");
        return YEAR = scanner.nextInt();
       
    }

    
}
