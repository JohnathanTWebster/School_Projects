
public class App {
    public static void main(String[] args) throws Exception {
        MyDate firstDate = new MyDate();
        MyDate secondDate = new MyDate(34355555133101L);


        System.out.println(firstDate.getYear() +"/"+ firstDate.getMonth() +"/"+ firstDate.getDay() );
        System.out.println(secondDate.getYear() +"/"+ secondDate.getMonth() +"/"+ secondDate.getDay() );
    }
}
