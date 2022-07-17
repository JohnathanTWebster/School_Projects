public class App {
    public static void main(String[] args) throws Exception {
        Account myAccount = new Account();
        SavingsAccount mySavingsAccount = new SavingsAccount();
        CheckingAccount myCheckingAccount = new CheckingAccount();

        System.out.println(myAccount.toString());
        System.out.println(mySavingsAccount.toString());
        System.out.println(myCheckingAccount.toString());
    }
}
