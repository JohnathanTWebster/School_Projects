public class App {
    public static void main(String[] args) throws Exception {

        Account myAccount = new Account(1122, 20000);

        myAccount.setAnnualInterestRate(4.5);
        myAccount.withdraw(2500);
        myAccount.deposit(3000);
        myAccount.setDateCreated();       
        System.out.println(myAccount.getBalance() + " " + myAccount.getMonthlyInterest() + " " + myAccount.getDateCreated());
    }
}
