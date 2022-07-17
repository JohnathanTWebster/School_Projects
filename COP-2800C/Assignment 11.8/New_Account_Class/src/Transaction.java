import java.util.*;

public class Transaction {

    //Properties

    private java.util.Date date;
    private char transactionType;
    private double ammount;
    private double balance;
    private String description;


    //Constructors
    Transaction(char transactionType, double ammount, double balance, String description){
         
        this.transactionType = transactionType;
        this.ammount = ammount;
        this.balance = balance;
        this.description = description;
        this.date = new java.util.Date();
    }

    Transaction(double ammount, double balance, String description){
         
        
        this.ammount = ammount;
        this.balance = balance;
        this.description = description;
        this.date = new java.util.Date();
    }

    Transaction(double ammount, double balance){
         
        
        this.ammount = ammount;
        this.balance = balance;
        this.date = new java.util.Date();
    }

  
    


    //Getters and Setters

    public Date getDateCreated() {
        return this.date;
    }
    public char getTransactionType() {
        return this.transactionType;
    }
    public double getAmmount() {
        return this.ammount;
    }
    public double getBalance() {
        return this.balance;
    }
    public String getDescription() {
        return this.description;
    }

    public void setDateCreated(Date dateCreated) {
        this.date = dateCreated;
    }
    public void setTransactionType(char transactionType) {
        this.transactionType = transactionType;
    }
    public void setAmmount(double ammount) {
        this.ammount = ammount;
    }
    public void setBalance(double balance) {
        this.balance = balance;
    }
    public void setDescription(String description) {
        this.description = description;
    }

    
}
