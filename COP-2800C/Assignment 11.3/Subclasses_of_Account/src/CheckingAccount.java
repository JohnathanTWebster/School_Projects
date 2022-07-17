public class CheckingAccount extends Account{
    
    private int overDraftLimit;
    String className = this.getClass().getSimpleName();

    CheckingAccount(){}

    public int getOverDraftLimit() {
        return this.overDraftLimit;
    }
    public void setOverDraftLimit(int overDraftLimit) {
        this.overDraftLimit = overDraftLimit;
    }
    @Override
    public String toString(){
        return ("This is the: " + className); 
    }
}
