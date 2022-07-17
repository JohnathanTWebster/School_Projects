import java.time.*;

public class Account {
  
//Properties 
private int id;
private double balance;
private double annualInterestRate;
private LocalDate dateCreated;
String className = this.getClass().getSimpleName();

//Constructors

Account(){
    setDateCreated();
}

Account(int id, double initalBalance){

    this.id = id;
    this.balance = initalBalance;
    setDateCreated();
}

//Functions

public double getMonthlyInterestRate(){

    return (this.annualInterestRate / 12) / 100;
}
public double getMonthlyInterest(){

    return this.balance * getMonthlyInterestRate();
}
public double withdraw(double withdrawAmount){
    return this.balance = this.balance - withdrawAmount;
}
public double deposit(double depositAmount){
    return this.balance = this.balance + depositAmount;
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
@Override
    public String toString(){
        return ("This is the: " + className); 
    }



}
