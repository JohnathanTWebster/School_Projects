import java.time.*;
import java.util.*;

public class Account {
  
//Properties 
private int id;
private double balance;
private double annualInterestRate;
private LocalDate dateCreated;
private String name;
private ArrayList<Transaction> transactions;


//Constructors

Account(){
    name = "";
	id = 0;
	balance = 0;
	annualInterestRate = 0;
	transactions = new ArrayList<Transaction>();
    setDateCreated();
}

Account(int id, double balance){

    name = "";
	this.id = 0;
	this.balance = 0;
	annualInterestRate = 0;
	transactions = new ArrayList<Transaction>();
    setDateCreated();
}

Account(String name, int id, double balance){
    this.name = name;
    this.id = id;
    this.balance = balance;
    transactions = new ArrayList<Transaction>();
    setDateCreated();
}

//Functions

public double getMonthlyInterestRate(){

    return (this.annualInterestRate / 12) / 100;
}
public double getMonthlyInterest(){

    return this.balance * getMonthlyInterestRate();
}
public void withdraw(double withdrawAmount){
    
    this.balance = this.balance - withdrawAmount;
    transactions.add(new Transaction('W', withdrawAmount, balance, "Withdrawal from account"));
}


public void deposit(double depositAmount){
    this.balance = this.balance + depositAmount;
    transactions.add(new Transaction('D', depositAmount, balance, "Deposit to account"));
}

//Accessors 

public int getId(){
    return this.id;
}
public double getBalance(){
    return this.balance;
}
public double getAnnualInterestRate(){
    return this.annualInterestRate;
}
public LocalDate getDateCreated(){
    return this.dateCreated;
}
public String getName() {
    return name;
}
public ArrayList<Transaction> getTransactions() {
    return transactions;
}

//Mutators

public int setID(int id){
    return this.id = id;
}
public double setBalance(double balance){
    return this.balance = balance;
}
public double setAnnualInterestRate(double annualInterestRate){
    return this.annualInterestRate = annualInterestRate;
}
public LocalDate setDateCreated(){
    return this.dateCreated = LocalDate.now();
}



}
