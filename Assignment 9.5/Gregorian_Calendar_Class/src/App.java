import java.util.*;

public class App {
    public static void main(String[] args) throws Exception {
        GregorianCalendar calendar = new GregorianCalendar();


        System.out.print(calendar.get(GregorianCalendar.YEAR)+"/");
        System.out.print(calendar.get(GregorianCalendar.MONTH)+"/");
        System.out.println(calendar.get(GregorianCalendar.DAY_OF_MONTH)+"\n");

        calendar.setTimeInMillis(34355555133101L);

        System.out.print(calendar.get(GregorianCalendar.YEAR)+"/");
        System.out.print(calendar.get(GregorianCalendar.MONTH)+"/");
        System.out.println(calendar.get(GregorianCalendar.DAY_OF_MONTH)+"\n");


    }
}
