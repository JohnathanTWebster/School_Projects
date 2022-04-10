public class App {
    public static void main(String[] args) throws Exception {

        System.out.println("Miles         Kilometers");
        for(int x = 1; x <= 10; x++){

            int miles = x;
            double kilometers = x * 1.609;
            if(x==10){
                System.out.println(miles + "            " + kilometers);
                continue;
            }
            System.out.println(miles + "             " + kilometers);

        }
    }
}
