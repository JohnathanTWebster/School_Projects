import java.util.*;

public class MyDate  {

    //properties
    private int year, month, day;
    private long date;
    GregorianCalendar myDate = new GregorianCalendar();
    
    //methods
    MyDate(){

        this.year = myDate.get(GregorianCalendar.YEAR);
        this.month = myDate.get(GregorianCalendar.MONTH);
        this.day = myDate.get(GregorianCalendar.DAY_OF_MONTH);

    }

    MyDate(long mili){

        
        myDate.setTimeInMillis(mili);
            
    }

    MyDate(int year, int month, int day){
        this.year = year;
        this.month = month;
        this.day = day;
    }

    //getters and setters
    public int getYear() {
        return this.myDate.get(GregorianCalendar.YEAR);
    }
    public int getDay() {
        return this.myDate.get(GregorianCalendar.DAY_OF_MONTH);
    }
    public int getMonth() {
        return this.month = myDate.get(GregorianCalendar.MONTH);
    }
    public void setDate(long date) {
        this.date = date;
    }
   
    
}
