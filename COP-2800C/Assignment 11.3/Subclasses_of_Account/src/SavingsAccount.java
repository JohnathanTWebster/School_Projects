public class SavingsAccount extends Account {

    private boolean overdrawn;
    String className = this.getClass().getSimpleName();


    SavingsAccount(){}


    @Override
    public String toString(){
        return ("This is the: " + className); 
    }
}
